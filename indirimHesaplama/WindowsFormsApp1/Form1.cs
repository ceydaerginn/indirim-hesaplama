using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(fiyat - (fiyat * 10 / 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(fiyat - (fiyat * 25 / 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(fiyat - (fiyat * 50 / 100));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(fiyat - (fiyat * 75 / 100));
        }
    }
}
