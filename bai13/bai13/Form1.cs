using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai13
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                int n = Convert.ToInt32(txtn.Text);
                int sum = 1;
                while (n >= 1)
                {
                    sum *= n;
                    n--;
                }
                txtkq.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Please input n");
                txtn.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                double n = Convert.ToDouble(txtn.Text);
                txtkq.Text = (1/(n+1)).ToString("G3");
            }
            else
            {
                MessageBox.Show("Please input n");
                txtn.Focus();
            }
        }
    }
}
