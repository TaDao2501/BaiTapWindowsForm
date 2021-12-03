using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                try
                {
                    int tong = 0;
                    int n = Convert.ToInt32(txtn.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        tong += i;
                    }
                    txtkq.Text = tong.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai định dạng n");
                    txtn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                try
                {
                    int tong = 0;
                    int n = Convert.ToInt32(txtn.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        tong += i;
                    }
                    txtkq.Text = (tong*tong).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai định dạng n");
                    txtn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                try
                {
                    int tong2=0;
                    int n = Convert.ToInt32(txtn.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        tong2 += i^(i+1);
                    }
                    txtkq.Text = tong2.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai định dạng n");
                    txtn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                try
                {
                    int tong1 = 0, tong2 = 0;
                    int n = Convert.ToInt32(txtn.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        tong1 += i;
                        tong2 += i ^ (i + 1);
                    }
                    txtkq.Text = ((double)tong1 / tong2).ToString("G3");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai định dạng n");
                    txtn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }
    }
}
