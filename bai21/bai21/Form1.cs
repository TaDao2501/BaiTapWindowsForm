using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                int n = Convert.ToInt32(txtn.Text);
                cboso.Items.Add(n);
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }

        private void cboso_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int item in listuoc.Items)
            {
                tong += item;
                
            }
            MessageBox.Show("Tổng các ước số : "+tong);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int item in listuoc.Items)
            {
                if (item % 2 == 0)
                {
                    dem++;
                }

            }
            MessageBox.Show("Số lượng ước số chẵn : " + dem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string snt = "";
            foreach (int item in listuoc.Items)
            {
                int dem = 0;
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    snt += item + " ";
                }
            }
            MessageBox.Show("Ước số nguyên tố : " + snt);
        }

        private void cboso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboso.SelectedItem != null)
            {
                int n = Convert.ToInt32(cboso.SelectedItem);
                listuoc.Items.Clear();
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        listuoc.Items.Add(i);
                    }
                }
            }
        }
    }
}
