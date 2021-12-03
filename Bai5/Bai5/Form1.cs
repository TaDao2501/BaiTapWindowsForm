using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "")
            {
                try
                {
                    double a = Convert.ToDouble(txtnum1.Text);
                    double b = Convert.ToDouble(txtnum2.Text);
                    txtkq.Text = (a+b).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn nhập sai định dạng số");
                    txtnum1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đủ 2 số");
                txtnum1.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
