
namespace NeoBridge.Models;

public class CameraDiscoveryResult
{
    public string CameraName { get; set; } = "";
    public List<CameraDriveResult> Drives { get; set; } = new();
}

public class CameraDriveResult
{
    public string DriveName { get; set; } = "";
    public List<string> Folders { get; set; } = new();
}
