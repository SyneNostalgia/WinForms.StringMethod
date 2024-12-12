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
            double height = 0;
            double weight = 0;
            if (!double.TryParse(txtheight.Text, out height))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (!double.TryParse(txtweight.Text, out weight))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double bmi = calBMI(height, weight);
            lblresult.Text = bmi.ToString("0.00");

            txtbase.Focus();
            txtbase.SelectAll();
        }
        private double calBMI(double h, double w)
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            double Thigh = 0;
            double Tbase = 0;
            if (!double.TryParse(txthigh.Text, out Thigh))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (!double.TryParse(txtbase.Text, out Tbase))
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double area = calTri(Thigh,Tbase);
            lblresult.Text = area.ToString("0.00");

            txtbase.Focus();
            txtbase.SelectAll();
        }
        private double calTri(double b,double h)
        {
            double TriArea = 0.5 * b * h;
            return TriArea;
        }
    }
}
