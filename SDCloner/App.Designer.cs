namespace SDCloner
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            PanelFooter = new Panel();
            LabelFollowMeOn = new Label();
            PictureBoxLinkedin = new PictureBox();
            LabelYear = new Label();
            LabelCreator = new Label();
            LabelLicense = new Label();
            PanelApp = new Panel();
            PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLinkedin).BeginInit();
            SuspendLayout();
            // 
            // PanelFooter
            // 
            PanelFooter.BackColor = Color.FromArgb(41, 78, 119);
            PanelFooter.Controls.Add(LabelFollowMeOn);
            PanelFooter.Controls.Add(PictureBoxLinkedin);
            PanelFooter.Controls.Add(LabelYear);
            PanelFooter.Controls.Add(LabelCreator);
            PanelFooter.Controls.Add(LabelLicense);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(0, 522);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(894, 51);
            PanelFooter.TabIndex = 0;
            // 
            // LabelFollowMeOn
            // 
            LabelFollowMeOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelFollowMeOn.AutoSize = true;
            LabelFollowMeOn.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFollowMeOn.ForeColor = Color.FromArgb(253, 253, 248);
            LabelFollowMeOn.Location = new Point(827, 12);
            LabelFollowMeOn.Name = "LabelFollowMeOn";
            LabelFollowMeOn.Size = new Size(55, 9);
            LabelFollowMeOn.TabIndex = 3;
            LabelFollowMeOn.Text = "Sígueme en";
            // 
            // PictureBoxLinkedin
            // 
            PictureBoxLinkedin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PictureBoxLinkedin.Cursor = Cursors.Hand;
            PictureBoxLinkedin.Image = Properties.Resources.linkedin_w_background;
            PictureBoxLinkedin.Location = new Point(809, 24);
            PictureBoxLinkedin.Name = "PictureBoxLinkedin";
            PictureBoxLinkedin.Size = new Size(73, 18);
            PictureBoxLinkedin.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLinkedin.TabIndex = 4;
            PictureBoxLinkedin.TabStop = false;
            PictureBoxLinkedin.Click += PictureBoxLinkedin_Click;
            // 
            // LabelYear
            // 
            LabelYear.AutoSize = true;
            LabelYear.Font = new Font("Microsoft Sans Serif", 6.5F);
            LabelYear.ForeColor = Color.FromArgb(253, 253, 248);
            LabelYear.Location = new Point(161, 30);
            LabelYear.Name = "LabelYear";
            LabelYear.Size = new Size(34, 12);
            LabelYear.TabIndex = 2;
            LabelYear.Text = "© 2025";
            // 
            // LabelCreator
            // 
            LabelCreator.AutoSize = true;
            LabelCreator.Font = new Font("Microsoft Sans Serif", 6.5F);
            LabelCreator.ForeColor = Color.FromArgb(253, 253, 248);
            LabelCreator.Location = new Point(12, 30);
            LabelCreator.Name = "LabelCreator";
            LabelCreator.Size = new Size(143, 12);
            LabelCreator.TabIndex = 1;
            LabelCreator.Text = "Desarrollado por Yosu Sanz Iriarte";
            // 
            // LabelLicense
            // 
            LabelLicense.AutoSize = true;
            LabelLicense.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            LabelLicense.ForeColor = Color.FromArgb(253, 253, 248);
            LabelLicense.Location = new Point(12, 15);
            LabelLicense.Name = "LabelLicense";
            LabelLicense.Size = new Size(118, 13);
            LabelLicense.TabIndex = 0;
            LabelLicense.Text = "Apache License 2.0";
            // 
            // PanelApp
            // 
            PanelApp.Dock = DockStyle.Fill;
            PanelApp.Location = new Point(0, 0);
            PanelApp.Name = "PanelApp";
            PanelApp.Size = new Size(894, 522);
            PanelApp.TabIndex = 3;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 248);
            ClientSize = new Size(894, 573);
            Controls.Add(PanelApp);
            Controls.Add(PanelFooter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += App_Load;
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLinkedin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFooter;
        private Label LabelLicense;
        private Label LabelYear;
        private Label LabelCreator;
        private Panel PanelApp;
        private PictureBox PictureBoxLinkedin;
        private Label LabelFollowMeOn;
    }
}
