using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int s = 0;
            string t = txtText.Text;
            if (!int.TryParse(txtSize.Text, out s))
            {
                MessageBox.Show("Please input only number in size.", " !!! Error !!! ");
                return;
            }
            if (comboBox1.SelectedItem?.ToString() == "A")
            {
                lblresult.Text = typeA(t, s);
            }
            else if (comboBox1.SelectedItem?.ToString() == "B")
            {
                lblresult.Text = typeB(t, s);
            }
            else if (comboBox1.SelectedItem?.ToString() == "C")
            {
                lblresult.Text = typeC(t, s);
            }
            else { MessageBox.Show("Please select the type.", " !!! Error !!! "); }
        }
        string typeC(string letter, int size)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
            return result;
        }
        string typeB(string text, int size)
        {
            string result = "";

            for (int i = 0; i < 6; i++)
            {
                result += text;
            }
            result += "\n";
            for (int i = 1; i <= size; i++)
            {
                result += text;
                for (int j = 0; j < 4; j++)
                {
                    result += i;
                }
                result += text;
                result += "\n";
            }
            for (int i = 0; i < 6; i++)
            {
                result += text;
            }

            return result;
        }


        string typeA(string text, int size)
        {
            string result = "";

            for (int i = 0; i < 8; i++)
            {
                result += text;
            }
            result += "\n";
            for (int i = 0; i < size - 2; i++)
            {
                result += text;
                result += "              ";
                result += text;
                result += "\n";
            }
            for (int i = 0; i < 8; i++)
            {
                result += text;
            }

            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = AvgFor(numbers);
            lblresult.Text = "ค่าเฉลี่ยคือ : " + average;
        }
        static double AvgFor(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array ต้องไม่ว่างเปล่า");
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (double)sum / numbers.Length;
        }
        static double AvgForeach(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array ต้องไม่ว่างเปล่า");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            int[] numbers = { 70, 25, 57, 42, 50 };
            double average = AvgForeach(numbers);
            lblresult.Text = "ค่าเฉลี่ยคือ : " + average;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] thetype = { "A", "B", "C" };
            comboBox1.Items.AddRange(thetype);
            string[] sc = { "มากไปน้อย", "น้อยไปมาก" };
            comboBox2.Items.AddRange(sc);
        }

        private void btnReang_Click(object sender, EventArgs e)
        {
            int[] data = { 5, 3, 8, 1, 10 };
            if (comboBox2.SelectedItem?.ToString() == "มากไปน้อย")
            {
                lblresult.Text = string.Join(", ", Desc(data)); ;
            }
            else if (comboBox2.SelectedItem?.ToString() == "น้อยไปมาก")
            {
                lblresult.Text = string.Join(", ", Asc(data));
            }
            else { MessageBox.Show("Please select Asc Desc.", " !!! Error !!! "); }
        }
        static int[] Desc(int[] array)
        {
            return array.OrderByDescending(x => x).ToArray();
        }
        static int[] Asc(int[] array)
        {
            return array.OrderBy(x => x).ToArray();
        }
    }
}
