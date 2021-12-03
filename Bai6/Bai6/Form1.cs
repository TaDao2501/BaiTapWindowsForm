using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtx.Focus();
        }

        private void txtexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txty.Text != "")
            {
                try
                {
                    double y = Convert.ToDouble(txty.Text);
                    double tong = y + y;
                    txtkq.Text = tong.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txty.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txty.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "" && txty.Text != "")
            {
                try
                {
                    double x = Convert.ToDouble(txtx.Text);
                    double y = Convert.ToDouble(txty.Text);
                    double kq= x- y;
                    txtkq.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txtx.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txtx.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "" && txty.Text != "")
            {
                try
                {
                    double x = Convert.ToDouble(txtx.Text);
                    double y = Convert.ToDouble(txty.Text);
                    double kq = x *y;
                    txtkq.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txtx.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txtx.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "" )
            {
                try
                {
                    double x = Convert.ToDouble(txtx.Text);
                   
                    double kq = x*x;
                    txtkq.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txtx.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txtx.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "")
            {
                try
                {
                    double x = Convert.ToDouble(txtx.Text);

                    double kq = x * x*x;
                    txtkq.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txtx.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txtx.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "")
            {
                try
                {
                    double x = Convert.ToDouble(txtx.Text);

                    double kq = Math.Sqrt(x);
                    txtkq.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong format!");
                    txtx.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill all box");
                txtx.Focus();
            }
        }
    }
}
