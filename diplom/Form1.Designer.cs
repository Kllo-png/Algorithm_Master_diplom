namespace diplom
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            aloneProgressBar1 = new ReaLTaiizor.Controls.AloneProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aloneProgressBar1
            // 
            aloneProgressBar1.BackColor = Color.Transparent;
            aloneProgressBar1.BackgroundColor = Color.Yellow;
            aloneProgressBar1.BaseColor = Color.FromArgb(45, 45, 48);
            aloneProgressBar1.BorderColor = Color.DodgerBlue;
            aloneProgressBar1.Location = new Point(61, 478);
            aloneProgressBar1.Maximum = 100;
            aloneProgressBar1.Minimum = 0;
            aloneProgressBar1.Name = "aloneProgressBar1";
            aloneProgressBar1.Size = new Size(777, 50);
            aloneProgressBar1.Stripes = Color.SeaGreen;
            aloneProgressBar1.TabIndex = 0;
            aloneProgressBar1.Text = "aloneProgressBar1";
            aloneProgressBar1.Value = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.AutoSize = true;
            parrotGradientPanel1.BottomLeft = Color.FromArgb(45, 45, 48);
            parrotGradientPanel1.BottomRight = Color.FromArgb(45, 45, 48);
            parrotGradientPanel1.CausesValidation = false;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            parrotGradientPanel1.Controls.Add(bigLabel2);
            parrotGradientPanel1.Controls.Add(bigLabel1);
            parrotGradientPanel1.Controls.Add(pictureBox1);
            parrotGradientPanel1.Controls.Add(aloneProgressBar1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Default;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(910, 540);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 4;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(0, 122, 204);
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 122, 204);
            parrotGradientPanel1.Paint += parrotGradientPanel1_Paint;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(259, 440);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(387, 24);
            bigLabel2.TabIndex = 3;
            bigLabel2.Text = "Визуализация алгоритмов в массивах";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft Sans Serif", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(288, 395);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(335, 38);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Мастер алгоритмов";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Algorithm_Master.Properties.Resources.pseudo_logo_2;
            pictureBox1.Location = new Point(284, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 245);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(910, 540);
            Controls.Add(parrotGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Загрузка";
            Load += Form1_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
    }
}
