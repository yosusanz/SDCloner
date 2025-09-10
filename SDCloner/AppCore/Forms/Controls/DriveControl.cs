using SDCloner.AppCore.Models;
using SDCloner.AppCore.Services;

namespace SDCloner.AppCore.Forms.Controls
{
    public partial class DriveControl : UserControl
    {
        private RemovableDrive _removableDrive;
        private ImageFile _imgFile;
        private readonly BurnService _burnService = new BurnService();

        private ushort _remainTime = 0;


        public DriveControl(RemovableDrive removableDrive, ImageFile imgFile)
        {
            InitializeComponent();

            _removableDrive = removableDrive;
            _imgFile = imgFile;
        }

        private void DriveControl_Load(object sender, EventArgs e)
        {
            HidePanels();
            PanelDrive.Visible = true;
            PanelDrive.Dock = DockStyle.Fill;

            LabelDriveName.Text = _removableDrive.DeviceID;
            LabelDriveVolumeName.Text = _removableDrive.VolumeLabel;

            bool valid = new DriveService().isDriveCapacityEnough(_removableDrive, _imgFile);
            CheckBoxBurn.Checked = valid;
            CheckBoxBurn.Enabled = valid;
        }

        public bool IsChecked() => CheckBoxBurn.Checked;
        public bool IsBurning() => PanelBurning.Visible;
        public ushort RemainTime() => _remainTime;

        public async Task StartBurning()
        {
            HidePanels();
            PanelBurning.Visible = true;
            LabelBurningProgress.Text = string.Empty;
            PanelBurning.Dock = DockStyle.Fill;

            IProgress<BurnProgress> progress = new Progress<BurnProgress>(p =>
            {
                LabelBurningProgress.Text = $"{p.Percent}%";
                _remainTime = p.RemainingTime;
            });

            
            try
            {
                await _burnService.BurnAsync(_removableDrive, _imgFile, progress);

                PanelBurning.Visible = false;
                PanelOK.Visible = true;
                PanelOK.Dock = DockStyle.Fill;
            }
            catch
            {
                this.Invoke(() =>
                {
                    PanelBurning.Visible = false;
                    Panel_ERROR.Visible = true;
                    Panel_ERROR.Dock = DockStyle.Fill;
                });
            }

        }
        
        private void HidePanels()
        {
            PanelDrive.Visible = false;
            PanelBurning.Visible = false;
            PanelOK.Visible = false;
            Panel_ERROR.Visible = false;
        }

    }
}
