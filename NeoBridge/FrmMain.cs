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
            new System.Threading.Timer (_ =>
            {
                var devices = _cameraService.GetAvailableDevices();
                Invoke(() =>
                {
                    CmbDevice.DataSource = devices;
                    CmbDevice.DisplayMember = "FriendlyName";
                });
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));



        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _cameraService.Connect((CameraDeviceInfo)CmbDevice.SelectedItem);
            CmbDrive.DataSource = _cameraService.GetDrives();
            CmbDrive.DisplayMember = "Name";
        }
    }
}
