namespace NeoBridge.Models
{

    public sealed record CameraDeviceInfo(string FriendlyName);

    public sealed record CameraDrive(string Id, string Name, string RootPath);

    public sealed record CameraFolder(string FullPath, string Name);

    public sealed record CameraFile(string FullPath, string Name);
}