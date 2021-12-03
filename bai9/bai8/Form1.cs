using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text != "" && txtb.Text != "" && txtc.Text != "")
            {

                double a = Convert.ToDouble(txta.Text);
                double b = Convert.ToDouble(txtb.Text);
                double c = Convert.ToDouble(txtc.Text);
                if (a == 0)
                {
                    new bacnhat(b,c).Show();
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        txtx1.Text = "Phương trình vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        txtx1.Text = "Phương trình có nghiệm kép x = " + ((-b) / (2 * a));
                    }
                    else
                    {
                        txtx1.Text=((-b)+Math.Sqrt(delta))/(2*a)+"";
                        txtx2.Text = ((-b) - Math.Sqrt(delta)) / (2 * a) + "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ 3 số");
            }
        }
    }
}
