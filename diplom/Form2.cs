using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form2 : Form
    {

  




        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void foxButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 1;

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foxButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 2;
        }

        private void foxButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 3;
        }

        private void foxButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 4;
        }

        private void foxButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 5;
        }

        private void foxButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 6;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void foxButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 7;
        }

        private void foxButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 8;
        }

        private void foxButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            OptionChoice.option = 9;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
    public static class OptionChoice
    {
        public static int option { get; set; } = 1;
    }


}
