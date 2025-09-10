namespace SDCloner.AppCore.Forms
{
    partial class BurningScreen
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
            PanelFileInfo = new Panel();
            ButtonBack = new Button();
            LabelImgFile = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            FlowLayoutPanelDetectedDrives = new FlowLayoutPanel();
            PanelTitle = new Panel();
            PictureBoxRefresh = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonBurn = new Button();
            PanelRemainTime = new Panel();
            LabelRemainTimeValue = new Label();
            LabelRemainTimeTitle = new Label();
            PanelFileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRefresh).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            PanelRemainTime.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFileInfo
            // 
            PanelFileInfo.BackColor = SystemColors.Control;
            PanelFileInfo.Controls.Add(ButtonBack);
            PanelFileInfo.Controls.Add(LabelImgFile);
            PanelFileInfo.Controls.Add(pictureBox1);
            PanelFileInfo.Dock = DockStyle.Left;
            PanelFileInfo.Location = new Point(0, 0);
            PanelFileInfo.Name = "PanelFileInfo";
            PanelFileInfo.Size = new Size(260, 644);
            PanelFileInfo.TabIndex = 0;
            // 
            // ButtonBack
            // 
            ButtonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonBack.BackColor = Color.DimGray;
            ButtonBack.Cursor = Cursors.Hand;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ButtonBack.ForeColor = Color.FromArgb(253, 253, 248);
            ButtonBack.Location = new Point(65, 581);
            ButtonBack.Margin = new Padding(125, 0, 125, 3);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(138, 31);
            ButtonBack.TabIndex = 8;
            ButtonBack.Text = "Volver";
            ButtonBack.UseVisualStyleBackColor = false;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // LabelImgFile
            // 
            LabelImgFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelImgFile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelImgFile.ForeColor = Color.DimGray;
            LabelImgFile.Location = new Point(11, 137);
            LabelImgFile.Name = "LabelImgFile";
            LabelImgFile.Size = new Size(239, 72);
            LabelImgFile.TabIndex = 7;
            LabelImgFile.Text = "Nombre archivo";
            LabelImgFile.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.img_file;
            pictureBox1.Location = new Point(65, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 78, 119);
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(369, 25);
            label1.TabIndex = 2;
            label1.Text = "Selecciona las microSDs a grabar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanelDetectedDrives
            // 
            FlowLayoutPanelDetectedDrives.AutoScroll = true;
            FlowLayoutPanelDetectedDrives.Dock = DockStyle.Fill;
            FlowLayoutPanelDetectedDrives.Location = new Point(260, 66);
            FlowLayoutPanelDetectedDrives.Name = "FlowLayoutPanelDetectedDrives";
            FlowLayoutPanelDetectedDrives.Padding = new Padding(32, 32, 32, 0);
            FlowLayoutPanelDetectedDrives.Size = new Size(753, 483);
            FlowLayoutPanelDetectedDrives.TabIndex = 3;
            // 
            // PanelTitle
            // 
            PanelTitle.Controls.Add(PictureBoxRefresh);
            PanelTitle.Controls.Add(label1);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(260, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(753, 66);
            PanelTitle.TabIndex = 4;
            // 
            // PictureBoxRefresh
            // 
            PictureBoxRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PictureBoxRefresh.Cursor = Cursors.Hand;
            PictureBoxRefresh.Image = Properties.Resources.icon_refresh1;
            PictureBoxRefresh.Location = new Point(692, 25);
            PictureBoxRefresh.Name = "PictureBoxRefresh";
            PictureBoxRefresh.Size = new Size(38, 25);
            PictureBoxRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxRefresh.TabIndex = 3;
            PictureBoxRefresh.TabStop = false;
            PictureBoxRefresh.Click += PictureBoxRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ButtonBurn, 1, 0);
            tableLayoutPanel1.Controls.Add(PanelRemainTime, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(260, 549);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(753, 95);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // ButtonBurn
            // 
            ButtonBurn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonBurn.BackColor = Color.FromArgb(41, 78, 119);
            ButtonBurn.Cursor = Cursors.Hand;
            ButtonBurn.FlatStyle = FlatStyle.Flat;
            ButtonBurn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ButtonBurn.ForeColor = Color.FromArgb(253, 253, 248);
            ButtonBurn.Location = new Point(301, 27);
            ButtonBurn.Margin = new Padding(0);
            ButtonBurn.Name = "ButtonBurn";
            ButtonBurn.Size = new Size(150, 40);
            ButtonBurn.TabIndex = 4;
            ButtonBurn.Text = "Grabar";
            ButtonBurn.UseVisualStyleBackColor = false;
            ButtonBurn.Click += ButtonBurn_Click;
            // 
            // PanelRemainTime
            // 
            PanelRemainTime.Controls.Add(LabelRemainTimeValue);
            PanelRemainTime.Controls.Add(LabelRemainTimeTitle);
            PanelRemainTime.Dock = DockStyle.Fill;
            PanelRemainTime.Location = new Point(454, 3);
            PanelRemainTime.Name = "PanelRemainTime";
            PanelRemainTime.Size = new Size(296, 89);
            PanelRemainTime.TabIndex = 5;
            // 
            // LabelRemainTimeValue
            // 
            LabelRemainTimeValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelRemainTimeValue.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRemainTimeValue.ForeColor = Color.DimGray;
            LabelRemainTimeValue.Location = new Point(-3, 42);
            LabelRemainTimeValue.Name = "LabelRemainTimeValue";
            LabelRemainTimeValue.Size = new Size(296, 24);
            LabelRemainTimeValue.TabIndex = 9;
            LabelRemainTimeValue.Text = "01:59";
            LabelRemainTimeValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelRemainTimeTitle
            // 
            LabelRemainTimeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelRemainTimeTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRemainTimeTitle.ForeColor = Color.DimGray;
            LabelRemainTimeTitle.Location = new Point(-3, 20);
            LabelRemainTimeTitle.Name = "LabelRemainTimeTitle";
            LabelRemainTimeTitle.Size = new Size(296, 24);
            LabelRemainTimeTitle.TabIndex = 8;
            LabelRemainTimeTitle.Text = "Tiempo estimado:";
            LabelRemainTimeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BurningScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 248);
            Controls.Add(FlowLayoutPanelDetectedDrives);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PanelTitle);
            Controls.Add(PanelFileInfo);
            Name = "BurningScreen";
            Size = new Size(1013, 644);
            Load += BurningScreen_Load;
            PanelFileInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxRefresh).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            PanelRemainTime.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFileInfo;
        private Label LabelImgFile;
        private PictureBox pictureBox1;
        private Button ButtonBack;
        private Label label1;
        private FlowLayoutPanel FlowLayoutPanelDetectedDrives;
        private Panel PanelTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonBurn;
        private PictureBox PictureBoxRefresh;
        private Label LabelRemainTimeTitle;
        private Panel PanelRemainTime;
        private Label LabelRemainTimeValue;
    }
}
