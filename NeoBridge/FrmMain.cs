using NeoBridge.Models;
using NeoBridge.Services;
using System.Diagnostics;

namespace NeoBridge
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        CameraWatcher _cameraWatcher = new CameraWatcher();

        private readonly CameraWatcher _cameraService = new CameraWatcher();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var result = _cameraWatcher.FindDevices();

            if (result != null)
            {
                Debug.WriteLine(result.CameraName);

                foreach (var drive in result.Drives)
                {
                    Debug.WriteLine($"Drive: {drive.DriveName}");

                    foreach (var folder in drive.Folders)
                    {
                        Debug.WriteLine($"  - {folder}");
                    }
                }
            }


        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _cameraService.Connect((CameraDeviceInfo)CmbDevice.SelectedItem);
            CmbDrive.DataSource = _cameraService.GetDrives();
            CmbDrive.DisplayMember = "Name";
        }
    }
}
