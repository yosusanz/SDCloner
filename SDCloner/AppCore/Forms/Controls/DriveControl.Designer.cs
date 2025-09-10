namespace SDCloner.AppCore.Forms.Controls
{
    partial class DriveControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PanelDrive = new Panel();
            CheckBoxBurn = new CheckBox();
            LabelDriveVolumeName = new Label();
            LabelDriveName = new Label();
            PictureSD = new PictureBox();
            PanelBurning = new Panel();
            LabelBurningProgress = new Label();
            LabelBurningText = new Label();
            PictureBoxBurningMicroSD = new PictureBox();
            PanelOK = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Panel_ERROR = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            PanelDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureSD).BeginInit();
            PanelBurning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBurningMicroSD).BeginInit();
            PanelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_ERROR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PanelDrive
            // 
            PanelDrive.Controls.Add(CheckBoxBurn);
            PanelDrive.Controls.Add(LabelDriveVolumeName);
            PanelDrive.Controls.Add(LabelDriveName);
            PanelDrive.Controls.Add(PictureSD);
            PanelDrive.Location = new Point(145, 7);
            PanelDrive.Name = "PanelDrive";
            PanelDrive.Padding = new Padding(16);
            PanelDrive.Size = new Size(160, 123);
            PanelDrive.TabIndex = 10;
            // 
            // CheckBoxBurn
            // 
            CheckBoxBurn.Dock = DockStyle.Top;
            CheckBoxBurn.Location = new Point(16, 93);
            CheckBoxBurn.Name = "CheckBoxBurn";
            CheckBoxBurn.Padding = new Padding(35, 0, 30, 0);
            CheckBoxBurn.Size = new Size(128, 24);
            CheckBoxBurn.TabIndex = 3;
            CheckBoxBurn.Text = "Grabar";
            CheckBoxBurn.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxBurn.UseVisualStyleBackColor = true;
            // 
            // LabelDriveVolumeName
            // 
            LabelDriveVolumeName.Dock = DockStyle.Top;
            LabelDriveVolumeName.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDriveVolumeName.ForeColor = Color.DimGray;
            LabelDriveVolumeName.Location = new Point(16, 60);
            LabelDriveVolumeName.Name = "LabelDriveVolumeName";
            LabelDriveVolumeName.Padding = new Padding(0, 5, 0, 0);
            LabelDriveVolumeName.Size = new Size(128, 33);
            LabelDriveVolumeName.TabIndex = 8;
            LabelDriveVolumeName.Text = "NombreVolumen";
            LabelDriveVolumeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelDriveName
            // 
            LabelDriveName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            LabelDriveName.ForeColor = Color.FromArgb(41, 78, 119);
            LabelDriveName.Location = new Point(70, 32);
            LabelDriveName.Name = "LabelDriveName";
            LabelDriveName.Size = new Size(23, 25);
            LabelDriveName.TabIndex = 4;
            LabelDriveName.Text = "E:";
            LabelDriveName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureSD
            // 
            PictureSD.Dock = DockStyle.Top;
            PictureSD.Image = Properties.Resources.sd_border;
            PictureSD.Location = new Point(16, 16);
            PictureSD.Name = "PictureSD";
            PictureSD.Size = new Size(128, 44);
            PictureSD.SizeMode = PictureBoxSizeMode.Zoom;
            PictureSD.TabIndex = 1;
            PictureSD.TabStop = false;
            // 
            // PanelBurning
            // 
            PanelBurning.Controls.Add(LabelBurningProgress);
            PanelBurning.Controls.Add(LabelBurningText);
            PanelBurning.Controls.Add(PictureBoxBurningMicroSD);
            PanelBurning.Location = new Point(116, 26);
            PanelBurning.Name = "PanelBurning";
            PanelBurning.Padding = new Padding(16);
            PanelBurning.Size = new Size(162, 120);
            PanelBurning.TabIndex = 11;
            // 
            // LabelBurningProgress
            // 
            LabelBurningProgress.Dock = DockStyle.Top;
            LabelBurningProgress.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBurningProgress.ForeColor = Color.DimGray;
            LabelBurningProgress.Location = new Point(16, 60);
            LabelBurningProgress.Name = "LabelBurningProgress";
            LabelBurningProgress.Padding = new Padding(0, 5, 0, 0);
            LabelBurningProgress.Size = new Size(130, 57);
            LabelBurningProgress.TabIndex = 9;
            LabelBurningProgress.Text = "0%";
            LabelBurningProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelBurningText
            // 
            LabelBurningText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            LabelBurningText.ForeColor = Color.FromArgb(41, 78, 119);
            LabelBurningText.Location = new Point(16, 31);
            LabelBurningText.Name = "LabelBurningText";
            LabelBurningText.Size = new Size(130, 18);
            LabelBurningText.TabIndex = 5;
            LabelBurningText.Text = "GRABANDO";
            LabelBurningText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBoxBurningMicroSD
            // 
            PictureBoxBurningMicroSD.Dock = DockStyle.Top;
            PictureBoxBurningMicroSD.Image = Properties.Resources.sd_border_50;
            PictureBoxBurningMicroSD.Location = new Point(16, 16);
            PictureBoxBurningMicroSD.Name = "PictureBoxBurningMicroSD";
            PictureBoxBurningMicroSD.Size = new Size(130, 44);
            PictureBoxBurningMicroSD.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxBurningMicroSD.TabIndex = 2;
            PictureBoxBurningMicroSD.TabStop = false;
            // 
            // PanelOK
            // 
            PanelOK.Controls.Add(label2);
            PanelOK.Controls.Add(pictureBox1);
            PanelOK.Location = new Point(97, 67);
            PanelOK.Name = "PanelOK";
            PanelOK.Padding = new Padding(16);
            PanelOK.Size = new Size(162, 120);
            PanelOK.TabIndex = 12;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(130, 57);
            label2.TabIndex = 9;
            label2.Text = "Grabación correcta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.icon_ok;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Panel_ERROR
            // 
            Panel_ERROR.Controls.Add(label3);
            Panel_ERROR.Controls.Add(pictureBox2);
            Panel_ERROR.Location = new Point(65, 99);
            Panel_ERROR.Name = "Panel_ERROR";
            Panel_ERROR.Padding = new Padding(16);
            Panel_ERROR.Size = new Size(162, 120);
            Panel_ERROR.TabIndex = 13;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(16, 60);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 0);
            label3.Size = new Size(130, 57);
            label3.TabIndex = 9;
            label3.Text = "Error en la grabación";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.icon_error;
            pictureBox2.Location = new Point(16, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // DriveControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_ERROR);
            Controls.Add(PanelOK);
            Controls.Add(PanelBurning);
            Controls.Add(PanelDrive);
            MaximumSize = new Size(167, 130);
            MinimumSize = new Size(167, 130);
            Name = "DriveControl";
            Size = new Size(167, 130);
            Load += DriveControl_Load;
            PanelDrive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureSD).EndInit();
            PanelBurning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxBurningMicroSD).EndInit();
            PanelOK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_ERROR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDrive;
        private CheckBox CheckBoxBurn;
        private Label LabelDriveVolumeName;
        private Label LabelDriveName;
        private PictureBox PictureSD;
        private Panel PanelBurning;
        private Label LabelBurningText;
        private PictureBox PictureBoxBurningMicroSD;
        private Label LabelBurningProgress;
        private Panel PanelOK;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel Panel_ERROR;
        private Label label3;
        private PictureBox pictureBox2;
    }
}
