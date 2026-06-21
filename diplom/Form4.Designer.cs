namespace diplom
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            exampleWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage2 = new TabPage();
            exampleWeb2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox2 = new PictureBox();
            descriptionWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exampleWeb).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exampleWeb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descriptionWeb).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Montserrat Light", 36F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(585, -5);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(243, 75);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Справка";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Montserrat", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            bigLabel2.ForeColor = Color.Transparent;
            bigLabel2.Location = new Point(27, 98);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(131, 33);
            bigLabel2.TabIndex = 6;
            bigLabel2.Text = "Описание";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Montserrat", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            bigLabel3.ForeColor = Color.Transparent;
            bigLabel3.Location = new Point(834, 98);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(336, 33);
            bigLabel3.TabIndex = 7;
            bigLabel3.Text = "Пример реализации в коде";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Montserrat Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.ItemSize = new Size(267, 40);
            tabControl1.Location = new Point(834, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 625);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(34, 34, 34);
            tabPage1.Controls.Add(exampleWeb);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(530, 577);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "C++";
            // 
            // exampleWeb
            // 
            exampleWeb.AllowExternalDrop = true;
            exampleWeb.CreationProperties = null;
            exampleWeb.DefaultBackgroundColor = Color.White;
            exampleWeb.Location = new Point(-4, 0);
            exampleWeb.Name = "exampleWeb";
            exampleWeb.Size = new Size(531, 581);
            exampleWeb.TabIndex = 16;
            exampleWeb.ZoomFactor = 1D;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 34, 34);
            tabPage2.Controls.Add(exampleWeb2);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(530, 577);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "C#";
            // 
            // exampleWeb2
            // 
            exampleWeb2.AllowExternalDrop = true;
            exampleWeb2.CreationProperties = null;
            exampleWeb2.DefaultBackgroundColor = Color.White;
            exampleWeb2.Location = new Point(0, -2);
            exampleWeb2.Name = "exampleWeb2";
            exampleWeb2.Size = new Size(531, 581);
            exampleWeb2.TabIndex = 17;
            exampleWeb2.ZoomFactor = 1D;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 536);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(778, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // descriptionWeb
            // 
            descriptionWeb.AllowExternalDrop = true;
            descriptionWeb.CreationProperties = null;
            descriptionWeb.DefaultBackgroundColor = Color.White;
            descriptionWeb.Location = new Point(27, 134);
            descriptionWeb.Name = "descriptionWeb";
            descriptionWeb.Size = new Size(778, 396);
            descriptionWeb.TabIndex = 15;
            descriptionWeb.ZoomFactor = 1D;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1384, 771);
            Controls.Add(descriptionWeb);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel2);
            Controls.Add(bigLabel1);
            Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            FormClosed += Form4_FormClosed;
            Shown += Form4_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exampleWeb).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exampleWeb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)descriptionWeb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private Microsoft.Web.WebView2.WinForms.WebView2 descriptionWeb;
        private Microsoft.Web.WebView2.WinForms.WebView2 exampleWeb;
        private Microsoft.Web.WebView2.WinForms.WebView2 exampleWeb2;
    }
}