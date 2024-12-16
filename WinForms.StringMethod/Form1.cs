namespace WinForms.StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = "", firstname = "", lastname = "", title = "";
            int x = 0;

            fullname = txtFullname.Text.Trim();

            if (fullname.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("นาง") || fullname.StartsWith("นาย"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("เด็กหญิง"))
            {
                x = 8;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("เด็กชาย"))
            {
                x = 7;
                title = fullname.Substring(0, x);
            }
            else
            {
                x = fullname.LastIndexOf('.') + 1;
                title = fullname.Substring(0, x);
            }
            fullname = fullname.Substring(x).Trim();
            x = fullname.IndexOf(' ');
            firstname = fullname.Substring(0, x).Trim();
            lastname = fullname.Substring(x).Trim();

            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtFullname.Text = "น.ส.อชิตะ บุญมารักษ์";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "เด็กชายอชิตะ บุญมารักษ์";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "เด็กหญิงอชิตะ บุญมารักษ์";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "ผศ.ดร. อชิตะ บุญมารักษ์";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "อชิตะ บุญมารักษ์";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "Mr. อชิตะ บุญมารักษ์ ณ กุมภวาปี";
        }
    }
}
