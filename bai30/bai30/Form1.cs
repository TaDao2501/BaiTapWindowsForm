using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtnl.Text != "")
            {
                txtkq.Text = txtnl.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Nhap van ban");
                txtnl.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = txtnl.Text.Trim();
            string[] rs = text.Split(' ');
            txtkq.Text = "So tu :" + rs.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnl.Enabled = true;
            txtkq.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnl.Text != "")
            {
                txtkq.Text = txtnl.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("Nhap van ban");
                txtnl.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (char x in txtnl.Text)
            {
                if (char.IsLower(x))
                {
                    dem++;
                }
            }
            txtkq.Text = "So ky tu thuong " + dem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (char x in txtnl.Text)
            {
                if (char.IsUpper(x))
                {
                    dem++;
                }
            }
            txtkq.Text = "So ky tu hoa " + dem;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtnl.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = txtnl.Text.Trim();
            string[] rs = text.Split(' ');
            foreach (string x in rs)
            {
                txtkq.Text += x+ '\n';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string na = "";
            string pa = "";
            foreach (char x in txtnl.Text)
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    na += x+" ";
                }
                else{
                    pa += x+" ";
                }
            }
            txtkq.Text = "Nguyen am: " + na + ",phu am: " + pa;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string chuoi = txtnl.Text.Trim();
            chuoi.Replace("//s", "");
            txtkq.Text = chuoi;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
