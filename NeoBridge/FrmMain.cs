using NeoBridge.Core;
using NeoBridge.Models;

namespace NeoBridge
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private readonly CameraWatcher _cameraService = new CameraWatcher();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CmbDevice.DataSource = _cameraService.GetAvailableDevices();
            CmbDevice.DisplayMember = "FriendlyName";



        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _cameraService.Connect((CameraDeviceInfo)CmbDevice.SelectedItem);
            CmbDrive.DataSource = _cameraService.GetDrives();
            CmbDrive.DisplayMember = "Name";
        }
    }
}
