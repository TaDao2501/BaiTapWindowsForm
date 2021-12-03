using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtkq.Clear();
            txta.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text != "" && txtb.Text != "")
            {
                double a = Convert.ToDouble(txta.Text);
                double b = Convert.ToDouble(txtb.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtkq.Text = "Phuong trinh vo so nghiem";
                    }
                    else
                    {
                        txtkq.Text = "Phuong trinh vo nghiem";
                    }
                }
                else
                {
                    if (b == 0)
                    {
                        txtkq.Text = "Nghiem x=0";
                    }
                    else
                    {
                        txtkq.Text = "Nghiem x = "+((-b)/a);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ 2 số");
            }
        }

        private void txtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
