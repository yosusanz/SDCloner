using SDCloner.AppCore.Forms;
using SDCloner.AppCore.Helpers;
using SDCloner.AppCore.Models;
using System.Diagnostics;

namespace SDCloner
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            this.Text = $"{GlobalVars.APP_NAME} v.{GlobalVars.APP_VERSION}";
        }

        private void App_Load(object sender, EventArgs e)
        {
            if (!SecurityHelper.IsRunningAsAdmin())
            {
                MessageBox.Show(
                    "Esta aplicación requiere permisos de administrador para grabar en discos extraíbles.",
                    GlobalVars.APP_NAME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Application.Exit();
            }

            ShowImageFileScreen();
        }


        private void ShowImageFileScreen()
        {
            PanelApp.Controls.Clear();

            var control = new LoadImageFileScreen
            {
                Name = "LoadImageFile",
                Dock = DockStyle.Fill
            };
            control.ImgFileSelected += OnImageFileSelected;

            PanelApp.Controls.Add(control);
        }
        private void OnImageFileSelected(ImageFile imgFile) => ShowDriveSelectionScreen(imgFile);


        private void ShowDriveSelectionScreen(ImageFile imgFile)
        {
            PanelApp.Controls.Clear();

            var control = new BurningScreen(imgFile)
            {
                Name = "LoadDrives",
                Dock = DockStyle.Fill
            };

            control.BackToSelectImgFile += ShowImageFileScreen;

            PanelApp.Controls.Add(control);
        }

        private void PictureBoxLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/yosusanz/",
                UseShellExecute = true
            });
        }

    }
}
