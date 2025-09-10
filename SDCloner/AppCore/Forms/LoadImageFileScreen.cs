using SDCloner.AppCore.Models;

namespace SDCloner.AppCore.Forms
{
    public partial class LoadImageFileScreen : UserControl
    {
        public event Action<ImageFile>? ImgFileSelected;
        private ImageFile? _imgFile = null;

        public LoadImageFileScreen()
        {
            InitializeComponent();
            LabelSelectedImgFile.Visible = false;
            ButtonContinue.Visible = false;
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            if (_imgFile is not null)
            {
                ImgFileSelected?.Invoke(_imgFile);
            }
        }
        private void ButtonSelectImgFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecciona un archivo .img";
                dialog.Filter = "Archivos IMG (*.img)|*.img";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imageFilePath = dialog.FileName;
                    FileInfo fileInfo = new FileInfo(imageFilePath);
                    long imageFileSize = fileInfo.Length;

                    _imgFile = new ImageFile(imageFilePath, imageFileSize);


                    LabelSelectedImgFile.Text = Path.GetFileName(imageFilePath);
                    LabelSelectedImgFile.Visible = true;
                    ButtonContinue.Visible = true;
                }
            }

        }
    }
}
