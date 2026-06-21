using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace diplom
{
    public partial class Form4 : Form
    {
        private async Task LoadAlgorithmData()
        {
            try
            {
                await descriptionWeb.EnsureCoreWebView2Async(null);
                await exampleWeb.EnsureCoreWebView2Async(null);
                await exampleWeb2.EnsureCoreWebView2Async(null);
                string descriptionFile = $"algorithm_{OptionChoice.option}_description.html";
                string exampleFile=$"algorithm_{OptionChoice.option}_example.html";
                string exampleFile2 = $"algorithm_{OptionChoice.option}_example2.html";

                
                if (File.Exists(descriptionFile) && File.Exists(exampleFile) && File.Exists(exampleFile2))
                {
                    string absolutePath = Path.GetFullPath(descriptionFile);
                    descriptionWeb.CoreWebView2.Navigate(absolutePath);
                    absolutePath = Path.GetFullPath(exampleFile);
                    exampleWeb.CoreWebView2.Navigate(absolutePath);
                    absolutePath = Path.GetFullPath(exampleFile2);
                    exampleWeb2.CoreWebView2.Navigate(absolutePath);
                }
                else
                {
                    string errorHtml = "<html><body style='font-family: Arial; padding: 20px;'><h3>Файл с описанием не найден</h3></body></html>";
                    descriptionWeb.CoreWebView2.NavigateToString(errorHtml);
                    exampleWeb.CoreWebView2.NavigateToString(errorHtml);
                    exampleWeb2.CoreWebView2.NavigateToString(errorHtml);

                }

                
                //string exampleFile = $"algorithm_{OptionChoice.option}_example.txt";
                //string exampleFile2 = $"algorithm_{OptionChoice.option}_example2.txt";
                //if (File.Exists(exampleFile))
                //{
                //    example.Text = File.ReadAllText(exampleFile);
                //    example2.Text = File.ReadAllText(exampleFile2);
                //}
                //else
                //{
                //    example.Text = "Файл с примером не найден";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
            pictureBox2.Image = null;
            Image image1 = Image.FromFile($"{OptionChoice.option}.gif");
            pictureBox2.Image = image1;
        }
        
        public Form4()
        {
            InitializeComponent();
            FontManager.ApplyTo(this);

        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            LoadAlgorithmData();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void example_TextChanged(object sender)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
