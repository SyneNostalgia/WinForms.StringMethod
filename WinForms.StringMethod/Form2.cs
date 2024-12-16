using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double theu = 0;
            double t = 0;
            if (!double.TryParse(txtheight.Text, out theu))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (!double.TryParse(txtweight.Text, out t))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double speed = calspeed(theu, t);
            lblresult.Text = speed.ToString("0.00");

            txtbase.Focus();
            txtbase.SelectAll();
        }
        private double calspeed(double theu, double t)
        {
            double v = theu+ 9.8*t;
            return v;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            if (!double.TryParse(txthigh.Text, out a))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (!double.TryParse(txtbase.Text, out b))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double area = pythagoras(a,b);
            lblresult.Text = area.ToString("0.00");

            txtbase.Focus();
            txtbase.SelectAll();
        }
        private double pythagoras(double a,double b)
        {
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
    }
}
