using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodyy03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Vzdalenost(double a1, double a2, double b1, double b2)
        {
            double vysledek = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox1.Text);
            double x2 = double.Parse(textBox2.Text);
            double y1 = double.Parse(textBox3.Text);
            double y2 = double.Parse(textBox4.Text);

            double vysledek = Vzdalenost(x1, x2, y1, y2);
            MessageBox.Show("Vzdalenost dvou bodů je: " + vysledek);
        }
    }
}
