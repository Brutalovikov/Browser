using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AazTecOSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("vk.com/barrioaztecas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Print();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: webBrowser1.Navigate("www.vk.com"); break;
                case 1: webBrowser1.Navigate("olocoder.ru"); break;
                case 2: webBrowser1.Navigate("www.youtube.com"); break;
                case 3: webBrowser1.Navigate("www.google.com"); break;
                case 4: webBrowser1.Navigate("www.yandex.ru"); break;
                case 5: webBrowser1.Navigate("www.mail.ru"); break;
            }
        }
    }
}
