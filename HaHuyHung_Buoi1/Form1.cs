using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;

namespace HaHuyHung_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, delta;
            a = Convert.ToDouble(tbxa.Text);
            b = Convert.ToDouble(tbxb.Text);
            c = Convert.ToDouble(tbxc.Text);
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        tbxkq.Text = "Phương trình vô số nghiệm";
                    }
                    if (c != 0)
                    {
                        tbxkq.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    tbxkq.Text = "Phương trình có một nghiệm duy nhất:" + -c / b;
                }
            }
            else
            {
                if (delta < 0)
                {
                    tbxkq.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    tbxkq.Text = "Phương trình có nghiệm kép x1 = x2 =" + -b / 2 * a;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    tbxkq.Text = "Nghiệm của phương trình là: " + x1 + "và" + x2;
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
