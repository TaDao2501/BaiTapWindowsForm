using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai10
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
            txtkh.Clear();
            txtcu.Clear();
            txtmoi.Clear();
            txtgia1.Clear();
            txtgia2.Clear();
            txttien.Clear();
            numberdm.Value = 50;
            txtkh.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkh.Text != "" && txtcu.Text != "" && txtmoi.Text != "" && txtgia1.Text != "" && txtgia2.Text != "")
            {
                int cu = Convert.ToInt32(txtcu.Text);
                int moi = Convert.ToInt32(txtmoi.Text);
                int gia1 = Convert.ToInt32(txtgia1.Text);
                int gia2 = Convert.ToInt32(txtgia2.Text);

                int sodien = moi - cu;
 
                if (sodien < numberdm.Value)
                {
                    txttien.Text = (sodien * gia1).ToString();
                }
                else
                {
                    txttien.Text = (sodien * gia2).ToString();
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
