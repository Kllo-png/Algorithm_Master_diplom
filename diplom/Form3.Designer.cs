namespace diplom
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            CellCountTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            sortTimer = new System.Windows.Forms.Timer(components);
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            delayTrackBar = new TrackBar();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            fillbutton = new ReaLTaiizor.Controls.FoxButton();
            sortbutton = new ReaLTaiizor.Controls.FoxButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nightPanel4 = new ReaLTaiizor.Controls.NightPanel();
            radioChartView = new RadioButton();
            radioGridView = new RadioButton();
            bigLabel12 = new ReaLTaiizor.Controls.BigLabel();
            nightPanel3 = new ReaLTaiizor.Controls.NightPanel();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            DirectionComboBox = new ReaLTaiizor.Controls.DungeonComboBox();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            MaxRange = new TextBox();
            MinRange = new TextBox();
            IntFloatChoice = new ReaLTaiizor.Controls.DungeonComboBox();
            bigLabel13 = new ReaLTaiizor.Controls.BigLabel();
            clearbutton = new ReaLTaiizor.Controls.FoxButton();
            panel2 = new Panel();
            nameLabel = new ReaLTaiizor.Controls.BigLabel();
            nightPanel5 = new ReaLTaiizor.Controls.NightPanel();
            NextPictureBox = new PictureBox();
            playPictureBox = new PictureBox();
            pausePictureBox = new PictureBox();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel3 = new Panel();
            logButton = new PictureBox();
            log = new ReaLTaiizor.Controls.MetroRichTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            legendPanel = new Panel();
            bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel10 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            nightPanel2 = new ReaLTaiizor.Controls.NightPanel();
            textBox3 = new TextBox();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            findbutton = new ReaLTaiizor.Controls.FoxButton();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)delayTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            nightPanel4.SuspendLayout();
            nightPanel3.SuspendLayout();
            nightPanel1.SuspendLayout();
            panel2.SuspendLayout();
            nightPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NextPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pausePictureBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            legendPanel.SuspendLayout();
            nightPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // CellCountTextBox
            // 
            CellCountTextBox.BackColor = Color.White;
            CellCountTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            CellCountTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            CellCountTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            CellCountTextBox.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CellCountTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            CellCountTextBox.Hint = "";
            errorProvider1.SetIconAlignment(CellCountTextBox, ErrorIconAlignment.TopLeft);
            CellCountTextBox.Location = new Point(409, 53);
            CellCountTextBox.MaxLength = 3;
            CellCountTextBox.Multiline = false;
            CellCountTextBox.Name = "CellCountTextBox";
            CellCountTextBox.PasswordChar = '\0';
            CellCountTextBox.ScrollBars = ScrollBars.None;
            CellCountTextBox.SelectedText = "";
            CellCountTextBox.SelectionLength = 0;
            CellCountTextBox.SelectionStart = 0;
            CellCountTextBox.Size = new Size(42, 40);
            CellCountTextBox.TabIndex = 0;
            CellCountTextBox.TabStop = false;
            CellCountTextBox.Text = "10";
            CellCountTextBox.UseSystemPasswordChar = false;
            CellCountTextBox.Click += CellCountTextBox_Click;
            CellCountTextBox.KeyPress += CellCountTextBox_KeyPress;
            CellCountTextBox.TextChanged += CellCountTextBox_TextChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Montserrat", 17.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bigLabel1.ForeColor = Color.FromArgb(241, 241, 241);
            bigLabel1.Location = new Point(3, 53);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(403, 36);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Количество элементов массива:";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dungeonLabel1.ForeColor = Color.FromArgb(241, 241, 241);
            dungeonLabel1.Location = new Point(942, 48);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(192, 30);
            dungeonLabel1.TabIndex = 6;
            dungeonLabel1.Text = "Задержка: 200 мс\r\n";
            // 
            // delayTrackBar
            // 
            delayTrackBar.LargeChange = 50;
            delayTrackBar.Location = new Point(943, 78);
            delayTrackBar.Maximum = 1000;
            delayTrackBar.Name = "delayTrackBar";
            delayTrackBar.Size = new Size(196, 45);
            delayTrackBar.SmallChange = 50;
            delayTrackBar.TabIndex = 7;
            delayTrackBar.Value = 200;
            delayTrackBar.Scroll += trackBar1_Scroll_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(134, 149);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 55;
            dataGridView1.RowTemplate.Height = 55;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(62, 48);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Width = 182;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.Width = 183;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.Width = 182;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // fillbutton
            // 
            fillbutton.BackColor = Color.Transparent;
            fillbutton.BaseColor = Color.FromArgb(0, 150, 136);
            fillbutton.BorderColor = Color.FromArgb(193, 193, 193);
            fillbutton.Cursor = Cursors.Hand;
            fillbutton.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            fillbutton.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            fillbutton.DisabledTextColor = Color.FromArgb(166, 178, 190);
            fillbutton.DownColor = Color.FromArgb(232, 232, 232);
            fillbutton.EnabledCalc = true;
            fillbutton.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fillbutton.ForeColor = Color.FromArgb(241, 241, 241);
            fillbutton.Location = new Point(33, 144);
            fillbutton.Name = "fillbutton";
            fillbutton.OverColor = Color.FromArgb(0, 122, 204);
            fillbutton.Size = new Size(166, 45);
            fillbutton.TabIndex = 10;
            fillbutton.Text = "Заполнить";
            fillbutton.Click += foxButton2_Click;
            // 
            // sortbutton
            // 
            sortbutton.BackColor = Color.Transparent;
            sortbutton.BaseColor = Color.FromArgb(0, 150, 136);
            sortbutton.BorderColor = Color.FromArgb(193, 193, 193);
            sortbutton.Cursor = Cursors.Hand;
            sortbutton.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            sortbutton.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            sortbutton.DisabledTextColor = Color.FromArgb(166, 178, 190);
            sortbutton.DownColor = Color.FromArgb(232, 232, 232);
            sortbutton.EnabledCalc = true;
            sortbutton.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sortbutton.ForeColor = Color.FromArgb(241, 241, 241);
            sortbutton.Location = new Point(37, 114);
            sortbutton.Name = "sortbutton";
            sortbutton.OverColor = Color.FromArgb(0, 122, 204);
            sortbutton.Size = new Size(166, 48);
            sortbutton.TabIndex = 11;
            sortbutton.Text = "Отсортировать";
            sortbutton.Click += foxButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 63, 65);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nightPanel4);
            panel1.Controls.Add(nightPanel3);
            panel1.Controls.Add(nightPanel1);
            panel1.Controls.Add(clearbutton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 771);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // nightPanel4
            // 
            nightPanel4.Controls.Add(radioChartView);
            nightPanel4.Controls.Add(radioGridView);
            nightPanel4.Controls.Add(bigLabel12);
            nightPanel4.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel4.LeftSideColor = Color.FromArgb(45, 45, 48);
            nightPanel4.Location = new Point(15, 511);
            nightPanel4.Name = "nightPanel4";
            nightPanel4.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel4.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel4.Size = new Size(240, 184);
            nightPanel4.TabIndex = 17;
            // 
            // radioChartView
            // 
            radioChartView.AutoSize = true;
            radioChartView.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioChartView.Location = new Point(7, 114);
            radioChartView.Name = "radioChartView";
            radioChartView.Size = new Size(230, 29);
            radioChartView.TabIndex = 1;
            radioChartView.TabStop = true;
            radioChartView.Text = "Столбчатая диаграмма";
            radioChartView.UseVisualStyleBackColor = true;
            radioChartView.CheckedChanged += radioChartView_CheckedChanged;
            // 
            // radioGridView
            // 
            radioGridView.AutoSize = true;
            radioGridView.Checked = true;
            radioGridView.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioGridView.Location = new Point(7, 55);
            radioGridView.Name = "radioGridView";
            radioGridView.Size = new Size(103, 29);
            radioGridView.TabIndex = 0;
            radioGridView.TabStop = true;
            radioGridView.Text = "Таблица";
            radioGridView.UseVisualStyleBackColor = true;
            radioGridView.CheckedChanged += radioGridView_CheckedChanged;
            // 
            // bigLabel12
            // 
            bigLabel12.AutoSize = true;
            bigLabel12.BackColor = Color.Transparent;
            bigLabel12.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel12.ForeColor = SystemColors.ButtonShadow;
            bigLabel12.Location = new Point(15, 13);
            bigLabel12.Name = "bigLabel12";
            bigLabel12.Size = new Size(211, 25);
            bigLabel12.TabIndex = 12;
            bigLabel12.Text = "Режим визуализации";
            bigLabel12.Click += bigLabel12_Click;
            // 
            // nightPanel3
            // 
            nightPanel3.Controls.Add(bigLabel7);
            nightPanel3.Controls.Add(sortbutton);
            nightPanel3.Controls.Add(DirectionComboBox);
            nightPanel3.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel3.LeftSideColor = Color.FromArgb(45, 45, 48);
            nightPanel3.Location = new Point(15, 321);
            nightPanel3.Name = "nightPanel3";
            nightPanel3.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel3.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel3.Size = new Size(240, 184);
            nightPanel3.TabIndex = 10;
            // 
            // bigLabel7
            // 
            bigLabel7.AutoSize = true;
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel7.ForeColor = SystemColors.ButtonShadow;
            bigLabel7.Location = new Point(8, 15);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(224, 25);
            bigLabel7.TabIndex = 12;
            bigLabel7.Text = "Настройки сортировки";
            // 
            // DirectionComboBox
            // 
            DirectionComboBox.BackColor = Color.FromArgb(246, 246, 246);
            DirectionComboBox.ColorA = Color.FromArgb(246, 132, 85);
            DirectionComboBox.ColorB = Color.FromArgb(231, 108, 57);
            DirectionComboBox.ColorC = Color.FromArgb(242, 241, 240);
            DirectionComboBox.ColorD = Color.FromArgb(253, 252, 252);
            DirectionComboBox.ColorE = Color.FromArgb(239, 237, 236);
            DirectionComboBox.ColorF = Color.FromArgb(180, 180, 180);
            DirectionComboBox.ColorG = Color.FromArgb(119, 119, 118);
            DirectionComboBox.ColorH = Color.FromArgb(224, 222, 220);
            DirectionComboBox.ColorI = Color.FromArgb(250, 249, 249);
            DirectionComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            DirectionComboBox.DropDownHeight = 100;
            DirectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DirectionComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DirectionComboBox.ForeColor = Color.FromArgb(76, 76, 97);
            DirectionComboBox.FormattingEnabled = true;
            DirectionComboBox.HoverSelectionColor = Color.Empty;
            DirectionComboBox.IntegralHeight = false;
            DirectionComboBox.ItemHeight = 20;
            DirectionComboBox.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            DirectionComboBox.Location = new Point(37, 57);
            DirectionComboBox.Name = "DirectionComboBox";
            DirectionComboBox.Size = new Size(166, 26);
            DirectionComboBox.StartIndex = 0;
            DirectionComboBox.TabIndex = 8;
            DirectionComboBox.SelectedIndexChanged += dungeonComboBox1_SelectedIndexChanged;
            // 
            // nightPanel1
            // 
            nightPanel1.Controls.Add(bigLabel6);
            nightPanel1.Controls.Add(fillbutton);
            nightPanel1.Controls.Add(bigLabel3);
            nightPanel1.Controls.Add(MaxRange);
            nightPanel1.Controls.Add(MinRange);
            nightPanel1.Controls.Add(IntFloatChoice);
            nightPanel1.Controls.Add(bigLabel13);
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(45, 45, 48);
            nightPanel1.Location = new Point(15, 100);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(240, 208);
            nightPanel1.TabIndex = 10;
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel6.ForeColor = SystemColors.ButtonShadow;
            bigLabel6.Location = new Point(9, 4);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(223, 25);
            bigLabel6.TabIndex = 10;
            bigLabel6.Text = "Настройки заполнения";
            bigLabel6.Click += bigLabel6_Click;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Microsoft Sans Serif", 12.2499981F);
            bigLabel3.ForeColor = Color.FromArgb(241, 241, 241);
            bigLabel3.Location = new Point(107, 101);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(15, 20);
            bigLabel3.TabIndex = 14;
            bigLabel3.Text = "-";
            // 
            // MaxRange
            // 
            MaxRange.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MaxRange.Location = new Point(132, 101);
            MaxRange.Name = "MaxRange";
            MaxRange.Size = new Size(94, 23);
            MaxRange.TabIndex = 15;
            MaxRange.Text = "101";
            MaxRange.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(MaxRange, "Максимальное значение диапазона");
            MaxRange.TextChanged += textBox2_TextChanged;
            MaxRange.KeyPress += textBox2_KeyPress;
            MaxRange.MouseHover += MaxRange_MouseHover;
            MaxRange.Validating += textBox2_Validating;
            // 
            // MinRange
            // 
            MinRange.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MinRange.Location = new Point(8, 100);
            MinRange.Name = "MinRange";
            MinRange.Size = new Size(89, 23);
            MinRange.TabIndex = 13;
            MinRange.Text = "0";
            MinRange.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(MinRange, "Минимальное значение диапазона");
            MinRange.TextChanged += textBox1_TextChanged;
            MinRange.KeyPress += textBox1_KeyPress;
            MinRange.MouseHover += MinRange_MouseHover;
            // 
            // IntFloatChoice
            // 
            IntFloatChoice.BackColor = Color.FromArgb(246, 246, 246);
            IntFloatChoice.ColorA = Color.FromArgb(246, 132, 85);
            IntFloatChoice.ColorB = Color.FromArgb(231, 108, 57);
            IntFloatChoice.ColorC = Color.FromArgb(242, 241, 240);
            IntFloatChoice.ColorD = Color.FromArgb(253, 252, 252);
            IntFloatChoice.ColorE = Color.FromArgb(239, 237, 236);
            IntFloatChoice.ColorF = Color.FromArgb(180, 180, 180);
            IntFloatChoice.ColorG = Color.FromArgb(119, 119, 118);
            IntFloatChoice.ColorH = Color.FromArgb(224, 222, 220);
            IntFloatChoice.ColorI = Color.FromArgb(250, 249, 249);
            IntFloatChoice.DrawMode = DrawMode.OwnerDrawFixed;
            IntFloatChoice.DropDownHeight = 100;
            IntFloatChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            IntFloatChoice.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IntFloatChoice.ForeColor = Color.FromArgb(76, 76, 97);
            IntFloatChoice.FormattingEnabled = true;
            IntFloatChoice.HoverSelectionColor = Color.Empty;
            IntFloatChoice.IntegralHeight = false;
            IntFloatChoice.ItemHeight = 20;
            IntFloatChoice.Items.AddRange(new object[] { "Целые числа", "Вещественные числа" });
            IntFloatChoice.Location = new Point(33, 38);
            IntFloatChoice.Name = "IntFloatChoice";
            IntFloatChoice.Size = new Size(169, 26);
            IntFloatChoice.StartIndex = 0;
            IntFloatChoice.TabIndex = 12;
            // 
            // bigLabel13
            // 
            bigLabel13.AutoSize = true;
            bigLabel13.BackColor = Color.Transparent;
            bigLabel13.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel13.ForeColor = Color.FromArgb(241, 241, 241);
            bigLabel13.Location = new Point(21, 69);
            bigLabel13.Name = "bigLabel13";
            bigLabel13.Size = new Size(190, 30);
            bigLabel13.TabIndex = 9;
            bigLabel13.Text = "Диапазон чисел";
            // 
            // clearbutton
            // 
            clearbutton.BackColor = Color.Transparent;
            clearbutton.BaseColor = Color.FromArgb(0, 150, 136);
            clearbutton.BorderColor = Color.FromArgb(193, 193, 193);
            clearbutton.Cursor = Cursors.Hand;
            clearbutton.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            clearbutton.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            clearbutton.DisabledTextColor = Color.FromArgb(166, 178, 190);
            clearbutton.DownColor = Color.FromArgb(232, 232, 232);
            clearbutton.EnabledCalc = true;
            clearbutton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearbutton.ForeColor = Color.FromArgb(241, 241, 241);
            clearbutton.Location = new Point(52, 711);
            clearbutton.Name = "clearbutton";
            clearbutton.OverColor = Color.FromArgb(0, 122, 204);
            clearbutton.Size = new Size(163, 48);
            clearbutton.TabIndex = 16;
            clearbutton.Text = "Очистить";
            clearbutton.Click += foxButton3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 63, 65);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(nightPanel5);
            panel2.Controls.Add(parrotPictureBox1);
            panel2.Controls.Add(bigLabel1);
            panel2.Controls.Add(dungeonLabel1);
            panel2.Controls.Add(delayTrackBar);
            panel2.Controls.Add(CellCountTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(274, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 100);
            panel2.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Montserrat ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.ForeColor = Color.FromArgb(241, 241, 241);
            nameLabel.Location = new Point(6, 7);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(29, 42);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "1";
            // 
            // nightPanel5
            // 
            nightPanel5.Controls.Add(NextPictureBox);
            nightPanel5.Controls.Add(playPictureBox);
            nightPanel5.Controls.Add(pausePictureBox);
            nightPanel5.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel5.LeftSideColor = Color.FromArgb(45, 45, 48);
            nightPanel5.Location = new Point(508, 7);
            nightPanel5.Name = "nightPanel5";
            nightPanel5.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel5.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel5.Size = new Size(196, 82);
            nightPanel5.TabIndex = 19;
            // 
            // NextPictureBox
            // 
            NextPictureBox.Enabled = false;
            NextPictureBox.Image = (Image)resources.GetObject("NextPictureBox.Image");
            NextPictureBox.Location = new Point(109, 7);
            NextPictureBox.Name = "NextPictureBox";
            NextPictureBox.Size = new Size(68, 68);
            NextPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            NextPictureBox.TabIndex = 20;
            NextPictureBox.TabStop = false;
            NextPictureBox.Click += NextPictureBox_Click;
            // 
            // playPictureBox
            // 
            playPictureBox.Image = (Image)resources.GetObject("playPictureBox.Image");
            playPictureBox.Location = new Point(18, 7);
            playPictureBox.Name = "playPictureBox";
            playPictureBox.Size = new Size(68, 68);
            playPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playPictureBox.TabIndex = 21;
            playPictureBox.TabStop = false;
            playPictureBox.Visible = false;
            playPictureBox.Click += playPictureBox_Click;
            // 
            // pausePictureBox
            // 
            pausePictureBox.Image = (Image)resources.GetObject("pausePictureBox.Image");
            pausePictureBox.Location = new Point(18, 7);
            pausePictureBox.Name = "pausePictureBox";
            pausePictureBox.Size = new Size(68, 68);
            pausePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pausePictureBox.TabIndex = 0;
            pausePictureBox.TabStop = false;
            pausePictureBox.Click += pausePictureBox_Click;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(180, 119);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(150, 150);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 8;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel3
            // 
            panel3.Controls.Add(logButton);
            panel3.Controls.Add(log);
            panel3.Controls.Add(hopePictureBox1);
            panel3.Controls.Add(legendPanel);
            panel3.Controls.Add(nightPanel2);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(274, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 671);
            panel3.TabIndex = 15;
            // 
            // logButton
            // 
            logButton.Image = (Image)resources.GetObject("logButton.Image");
            logButton.Location = new Point(1065, 56);
            logButton.Name = "logButton";
            logButton.Size = new Size(53, 45);
            logButton.SizeMode = PictureBoxSizeMode.Zoom;
            logButton.TabIndex = 19;
            logButton.TabStop = false;
            logButton.Click += logButton_Click;
            // 
            // log
            // 
            log.AutoWordSelection = false;
            log.BorderColor = Color.FromArgb(110, 110, 110);
            log.DisabledBackColor = Color.FromArgb(80, 80, 80);
            log.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            log.DisabledForeColor = Color.FromArgb(109, 109, 109);
            log.Font = new Font("Consolas", 12F);
            log.HoverColor = Color.FromArgb(170, 170, 170);
            log.IsDerivedStyle = true;
            log.Lines = null;
            log.Location = new Point(6, 4);
            log.MaxLength = 32767;
            log.Name = "log";
            log.ReadOnly = true;
            log.Size = new Size(1033, 662);
            log.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            log.StyleManager = null;
            log.TabIndex = 18;
            log.ThemeAuthor = "Taiizor";
            log.ThemeName = "MetroDark";
            log.Visible = false;
            log.WordWrap = true;
            log.TextChanged += log_TextChanged;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.Anchor = AnchorStyles.None;
            hopePictureBox1.BackColor = Color.Transparent;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(1064, 0);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(54, 50);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 17;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += hopePictureBox1_Click;
            // 
            // legendPanel
            // 
            legendPanel.BackColor = Color.FromArgb(60, 63, 65);
            legendPanel.Controls.Add(bigLabel11);
            legendPanel.Controls.Add(bigLabel10);
            legendPanel.Controls.Add(bigLabel9);
            legendPanel.Controls.Add(bigLabel8);
            legendPanel.Controls.Add(bigLabel5);
            legendPanel.Controls.Add(panel4);
            legendPanel.Controls.Add(panel7);
            legendPanel.Controls.Add(panel5);
            legendPanel.Controls.Add(panel6);
            legendPanel.Location = new Point(23, 427);
            legendPanel.Name = "legendPanel";
            legendPanel.Size = new Size(307, 232);
            legendPanel.TabIndex = 16;
            // 
            // bigLabel11
            // 
            bigLabel11.AutoSize = true;
            bigLabel11.BackColor = Color.Transparent;
            bigLabel11.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold | FontStyle.Italic);
            bigLabel11.ForeColor = Color.White;
            bigLabel11.Location = new Point(3, 4);
            bigLabel11.Name = "bigLabel11";
            bigLabel11.Size = new Size(120, 34);
            bigLabel11.TabIndex = 20;
            bigLabel11.Text = "Легенда";
            // 
            // bigLabel10
            // 
            bigLabel10.AutoSize = true;
            bigLabel10.BackColor = Color.Transparent;
            bigLabel10.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            bigLabel10.ForeColor = Color.White;
            bigLabel10.Location = new Point(46, 192);
            bigLabel10.Name = "bigLabel10";
            bigLabel10.Size = new Size(249, 22);
            bigLabel10.TabIndex = 19;
            bigLabel10.Text = "Опорный элемент/подмассивы";
            // 
            // bigLabel9
            // 
            bigLabel9.AutoSize = true;
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            bigLabel9.ForeColor = Color.White;
            bigLabel9.Location = new Point(46, 99);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(188, 22);
            bigLabel9.TabIndex = 18;
            bigLabel9.Text = "Выполненный элемент";
            bigLabel9.Click += bigLabel9_Click;
            // 
            // bigLabel8
            // 
            bigLabel8.AutoSize = true;
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            bigLabel8.ForeColor = Color.White;
            bigLabel8.Location = new Point(46, 149);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(178, 22);
            bigLabel8.TabIndex = 17;
            bigLabel8.Text = "Изменяемый элемент";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            bigLabel5.ForeColor = Color.White;
            bigLabel5.Location = new Point(46, 49);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(216, 22);
            bigLabel5.TabIndex = 16;
            bigLabel5.Text = "Рассматриваемый элемент";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(10, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 30);
            panel4.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Purple;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(10, 192);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 30);
            panel7.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(10, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 30);
            panel5.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(10, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 30);
            panel6.TabIndex = 14;
            panel6.Paint += panel6_Paint;
            // 
            // nightPanel2
            // 
            nightPanel2.Controls.Add(textBox3);
            nightPanel2.Controls.Add(bigLabel4);
            nightPanel2.Controls.Add(findbutton);
            nightPanel2.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel2.LeftSideColor = Color.FromArgb(60, 63, 65);
            nightPanel2.Location = new Point(409, 434);
            nightPanel2.Name = "nightPanel2";
            nightPanel2.RightSideColor = Color.FromArgb(60, 63, 65);
            nightPanel2.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel2.Size = new Size(203, 225);
            nightPanel2.TabIndex = 11;
            nightPanel2.Visible = false;
            nightPanel2.MouseHover += nightPanel2_MouseHover;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(51, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 32);
            textBox3.TabIndex = 16;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bigLabel4.ForeColor = Color.White;
            bigLabel4.Location = new Point(24, 22);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(160, 25);
            bigLabel4.TabIndex = 12;
            bigLabel4.Text = "Поиск элемента";
            // 
            // findbutton
            // 
            findbutton.BackColor = Color.Transparent;
            findbutton.BaseColor = Color.FromArgb(0, 150, 136);
            findbutton.BorderColor = Color.FromArgb(193, 193, 193);
            findbutton.Cursor = Cursors.Hand;
            findbutton.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            findbutton.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            findbutton.DisabledTextColor = Color.FromArgb(166, 178, 190);
            findbutton.DownColor = Color.FromArgb(232, 232, 232);
            findbutton.EnabledCalc = true;
            findbutton.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findbutton.ForeColor = Color.FromArgb(241, 241, 241);
            findbutton.Location = new Point(18, 164);
            findbutton.Name = "findbutton";
            findbutton.OverColor = Color.FromArgb(0, 122, 204);
            findbutton.Size = new Size(166, 48);
            findbutton.TabIndex = 11;
            findbutton.Text = "Найти";
            findbutton.Click += foxButton4_Click;
            findbutton.MouseHover += findbutton_MouseHover;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1424, 771);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Визуализация алгоритма";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            Shown += Form3_Shown;
            ((System.ComponentModel.ISupportInitialize)delayTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            nightPanel4.ResumeLayout(false);
            nightPanel4.PerformLayout();
            nightPanel3.ResumeLayout(false);
            nightPanel3.PerformLayout();
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            nightPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NextPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pausePictureBox).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            legendPanel.ResumeLayout(false);
            legendPanel.PerformLayout();
            nightPanel2.ResumeLayout(false);
            nightPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox CellCountTextBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer sortTimer;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private TrackBar delayTrackBar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ReaLTaiizor.Controls.FoxButton fillbutton;
        private ReaLTaiizor.Controls.FoxButton sortbutton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ReaLTaiizor.Controls.DungeonComboBox DirectionComboBox;
        private ReaLTaiizor.Controls.DungeonComboBox IntFloatChoice;
        private TextBox MaxRange;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private TextBox MinRange;
        private ReaLTaiizor.Controls.FoxButton clearbutton;
        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightPanel nightPanel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.NightPanel nightPanel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.FoxButton findbutton;
        private TextBox textBox3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel legendPanel;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel bigLabel10;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.MetroRichTextBox log;
        private RadioButton radioChartView;
        private RadioButton radioGridView;
        private ToolTip toolTip1;
        private ReaLTaiizor.Controls.NightPanel nightPanel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel12;
        private ReaLTaiizor.Controls.BigLabel bigLabel13;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightPanel nightPanel5;
        private PictureBox playPictureBox;
        private PictureBox NextPictureBox;
        private PictureBox pausePictureBox;
        private PictureBox logButton;
        private ReaLTaiizor.Controls.BigLabel nameLabel;
    }
}