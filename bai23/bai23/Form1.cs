using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace bai23
{
    public partial class Form1 : Form
    {
        ArrayList mang;
        public Form1()
        {
            InitializeComponent();
            mang = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text != "" && txtb.Text != "")
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);
                int n = b - 1;
                Random rd = new Random();
                for (int i = 0; i < n; i++)
                {
                    mang.Add(rd.Next(a,b));
                }
                foreach(int x in mang)
                {
                    txtday.Text += x + " ";
                }
                int tong = 0;
                foreach (int x in mang)
                {
                    tong += x ;
                }
                txttong.Text = tong.ToString();
                mang.Sort();
                foreach (int x in mang)
                {
                    txtsort.Text += x + " ";
                }
            }
            else
            {
                MessageBox.Show("Nhập 2 số");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.ReadOnly = false;
            txtb.ReadOnly = false;
        }
    }
}
