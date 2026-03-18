using MediaDevices;
using NeoBridge.Models;

namespace NeoBridge.Core
{
    public class CameraWatcher : IDisposable
    {
        private MediaDevice? _device;

        public bool IsConnected => _device?.IsConnected == true;
        public CameraDeviceInfo? ConnectedDevice { get; private set; }

        // -------- Devices --------

        public List<CameraDeviceInfo> GetAvailableDevices()
        {
            return [.. MediaDevice.GetDevices().Select(d => new CameraDeviceInfo(d.FriendlyName))];
        }

        // -------- Connection --------

        public bool Connect(CameraDeviceInfo deviceInfo)
        {
            Disconnect();

            var device = MediaDevice.GetDevices()
                .FirstOrDefault(d => d.FriendlyName == deviceInfo.FriendlyName);

            if (device == null)
                return false;

            device.Connect();

            _device = device;
            ConnectedDevice = deviceInfo;

            return true;
        }

        public void Disconnect()
        {
            _device?.Dispose();
            _device = null;
            ConnectedDevice = null;
        }

        // -------- Drives --------

        public List<CameraDrive> GetDrives()
        {
            EnsureConnected();

            return [.. _device!.GetDrives()
                .Select((drive, index) => new CameraDrive(
                    Id: drive.Name ?? $"Drive{index + 1}",
                    Name: drive.Name ?? $"Storage {index + 1}",
                    RootPath: drive.RootDirectory.FullName))];
        }

        // -------- Folders --------

        public List<CameraFolder> GetRootFolders()
        {
            EnsureConnected();

            var results = new List<CameraFolder>();

            foreach (var drive in _device!.GetDrives())
            {
                foreach (var dir in drive.RootDirectory.EnumerateDirectories())
                {
                    results.Add(new CameraFolder(
                        dir.FullName,
                        dir.Name));
                }
            }

            return results;
        }

        public List<CameraFolder> GetSubFolders(CameraFolder parent)
        {
            EnsureConnected();

            // Path-based APIs return strings → normalize here
            return [.. _device!.EnumerateDirectories(parent.FullPath)
                .Select(path => new CameraFolder(
                    path,
                    Path.GetFileName(path)))];
        }

        public bool FolderExists(CameraFolder folder)
        {
            EnsureConnected();
            return _device!.DirectoryExists(folder.FullPath);
        }

        // -------- Files --------

        public List<CameraFile> GetFiles(CameraFolder folder)
        {
            EnsureConnected();

            return [.. _device!.GetFiles(folder.FullPath)
                .Select(path => new CameraFile(
                    path,
                    Path.GetFileName(path)))];
        }

        public void DownloadFile(CameraFile file, string localDirectory)
        {
            EnsureConnected();

            Directory.CreateDirectory(localDirectory);

            string localPath = Path.Combine(localDirectory, file.Name);

            using var stream = File.Create(localPath);
            _device!.DownloadFile(file.FullPath, stream);
        }

        public void DeleteFile(CameraFile file)
        {
            EnsureConnected();
            _device!.DeleteFile(file.FullPath);
        }

        // -------- Guard --------

        private void EnsureConnected()
        {
            if (!IsConnected)
                throw new InvalidOperationException("No device connected.");
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}

