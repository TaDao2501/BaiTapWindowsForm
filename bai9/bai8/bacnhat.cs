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
    public partial class bacnhat : Form
    {
        double b, c;
        public bacnhat(double b,double c)
        {
            InitializeComponent();
            this.b = b;
            this.c = c;
            txta.Text = b;
            txtb.Text = c;
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
            
                if (b == 0)
                {
                    if (c == 0)
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
                    if (c == 0)
                    {
                        txtkq.Text = "Nghiem x=0";
                    }
                    else
                    {
                        txtkq.Text = "Nghiem x = " + ((-c) / b);
                    }
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
