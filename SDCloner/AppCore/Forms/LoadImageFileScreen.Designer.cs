namespace SDCloner.AppCore.Forms
{
    partial class LoadImageFileScreen
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
            label1 = new Label();
            ButtonSelectImgFile = new Button();
            LabelSelectedImgFile = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            ButtonContinue = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 78, 119);
            label1.Location = new Point(305, 82);
            label1.Name = "label1";
            label1.Size = new Size(382, 25);
            label1.TabIndex = 1;
            label1.Text = "Selecciona el archivo img a grabar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonSelectImgFile
            // 
            ButtonSelectImgFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonSelectImgFile.BackColor = Color.FromArgb(41, 78, 119);
            ButtonSelectImgFile.Cursor = Cursors.Hand;
            ButtonSelectImgFile.FlatStyle = FlatStyle.Flat;
            ButtonSelectImgFile.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ButtonSelectImgFile.ForeColor = Color.FromArgb(253, 253, 248);
            ButtonSelectImgFile.Location = new Point(392, 296);
            ButtonSelectImgFile.Margin = new Padding(90, 10, 90, 3);
            ButtonSelectImgFile.Name = "ButtonSelectImgFile";
            ButtonSelectImgFile.Size = new Size(208, 40);
            ButtonSelectImgFile.TabIndex = 3;
            ButtonSelectImgFile.Text = "Seleccionar archivo";
            ButtonSelectImgFile.UseVisualStyleBackColor = false;
            ButtonSelectImgFile.Click += ButtonSelectImgFile_Click;
            // 
            // LabelSelectedImgFile
            // 
            LabelSelectedImgFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelSelectedImgFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSelectedImgFile.ForeColor = Color.DimGray;
            LabelSelectedImgFile.Location = new Point(305, 358);
            LabelSelectedImgFile.Name = "LabelSelectedImgFile";
            LabelSelectedImgFile.Size = new Size(382, 56);
            LabelSelectedImgFile.TabIndex = 5;
            LabelSelectedImgFile.Text = "nombre archivo";
            LabelSelectedImgFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 388F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LabelSelectedImgFile, 1, 4);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 2);
            tableLayoutPanel2.Controls.Add(ButtonSelectImgFile, 1, 3);
            tableLayoutPanel2.Controls.Add(ButtonContinue, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(993, 546);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.img_file;
            pictureBox1.Location = new Point(305, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ButtonContinue
            // 
            ButtonContinue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonContinue.BackColor = Color.DimGray;
            ButtonContinue.Cursor = Cursors.Hand;
            ButtonContinue.FlatStyle = FlatStyle.Flat;
            ButtonContinue.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ButtonContinue.ForeColor = Color.FromArgb(253, 253, 248);
            ButtonContinue.Location = new Point(427, 422);
            ButtonContinue.Margin = new Padding(125, 0, 125, 3);
            ButtonContinue.Name = "ButtonContinue";
            ButtonContinue.Size = new Size(138, 31);
            ButtonContinue.TabIndex = 6;
            ButtonContinue.Text = "Continuar";
            ButtonContinue.UseVisualStyleBackColor = false;
            ButtonContinue.Click += ButtonContinue_Click;
            // 
            // LoadImageFileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 248);
            Controls.Add(tableLayoutPanel2);
            MinimumSize = new Size(394, 488);
            Name = "LoadImageFileControl";
            Size = new Size(993, 546);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button ButtonSelectImgFile;
        private Label LabelSelectedImgFile;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButtonContinue;
        private PictureBox pictureBox1;
    }
}
