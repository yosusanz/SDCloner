using SDCloner.AppCore.Forms.Controls;
using SDCloner.AppCore.Models;
using SDCloner.AppCore.Services;

namespace SDCloner.AppCore.Forms
{
    public partial class BurningScreen : UserControl
    {
        public event Action? BackToSelectImgFile;

        private ImageFile _imgFile;

        public BurningScreen(ImageFile imgFile)
        {
            InitializeComponent();

            _imgFile = imgFile;
            LabelImgFile.Text = Path.GetFileName(_imgFile.FilePath); 
        }

        private void BurningScreen_Load(object sender, EventArgs e)
        {
            PanelRemainTime.Visible = false;

            ListDrives();
        }
        
        private void ButtonBack_Click(object sender, EventArgs e) => BackToSelectImgFile?.Invoke();
        private async void ButtonBurn_Click(object sender, EventArgs e)
        {
            bool anySelected = false;

            if (!System.IO.File.Exists(_imgFile.FilePath))
            {
                DialogResult result = MessageBox.Show(
                    "Archivo IMG no encontrado. Asegúrate que el archivo img sigue existiendo.",
                    GlobalVars.APP_NAME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                BackToSelectImgFile?.Invoke();
                return;
            }

            foreach (DriveControl driveControl in FlowLayoutPanelDetectedDrives.Controls.OfType<DriveControl>())
            {
                if (driveControl.IsChecked())
                {
                    _ = driveControl.StartBurning();
                    anySelected = true;
                }
                else
                {
                    driveControl.Enabled = false;
                }
            }

            if (anySelected)
            {
                setBurningState(true);

                await CheckBurningStatusAsync();

                DialogResult result = MessageBox.Show(
                    "Grabación terminada. Desconecta los elementos grabados antes de continuar.",
                    GlobalVars.APP_NAME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListDrives();
            }
            else
            {
                EnableAllDriveControls();
            }

        }

        private async Task CheckBurningStatusAsync()
        {
            bool anyBurning;
            do
            {
                anyBurning = false;
                int maxRemainTime = 0;

                foreach (DriveControl driveControl in FlowLayoutPanelDetectedDrives.Controls.OfType<DriveControl>())
                {
                    if (driveControl.IsChecked() && driveControl.IsBurning())
                    {
                        anyBurning = true;
                        maxRemainTime = Math.Max(maxRemainTime, driveControl.RemainTime());
                    }
                }
                UpdateRemainTimeLabel(maxRemainTime);

                await Task.Delay(1000);

            } while (anyBurning);

            setBurningState(false);
        }
        private void EnableAllDriveControls()
        {
            foreach (DriveControl driveControl in FlowLayoutPanelDetectedDrives.Controls.OfType<DriveControl>())
            {
                driveControl.Enabled = true;
            }
        }
        private void ListDrives()
        {
            FlowLayoutPanelDetectedDrives.Controls.Clear();

            var removableDrives = new DriveService().GetRemovableDrives();
            foreach (var removableDrive in removableDrives)
            {
                var control = new DriveControl(removableDrive, _imgFile);
                control.Name = $"Drive_{removableDrive.DeviceID}";
                FlowLayoutPanelDetectedDrives.Controls.Add(control);
            }

            if (FlowLayoutPanelDetectedDrives.Controls.Count == 0)
            {
                var noDrivesLabel = new Label
                {
                    Text = "No se han detectado unidades extraibles.",
                    AutoSize = true
                };
                FlowLayoutPanelDetectedDrives.Controls.Add(noDrivesLabel);

                ButtonBurn.Visible = false;
            }
            else
            {
                ButtonBurn.Visible = true;
            }
        }
        private void PictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ListDrives();
        }
        private void setBurningState(bool isBurning)
        {
            ButtonBurn.Enabled = !isBurning;
            ButtonBack.Enabled = !isBurning;
            PictureBoxRefresh.Enabled = !isBurning;

            PanelRemainTime.Visible = isBurning;
            LabelRemainTimeValue.Text = string.Empty;
        }
        private void UpdateRemainTimeLabel(int seconds)
        {
            var timeSpan = TimeSpan.FromSeconds(seconds);
            LabelRemainTimeValue.Text = timeSpan.ToString(@"mm\:ss");
        }
    }
}
