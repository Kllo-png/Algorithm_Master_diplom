namespace diplom
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FontManager.ApplyTo(this);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aloneProgressBar1.Value != 100)
            {
                aloneProgressBar1.Value = ++aloneProgressBar1.Value;
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                timer1.Enabled = false;
            }
        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    public static class PanelExtensions
    {
        public static void SetRoundedCorners(this Panel panel, int radius)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, radius, radius));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
