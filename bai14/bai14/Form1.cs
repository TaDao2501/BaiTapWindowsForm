using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai14
{
    public partial class Form1 : Form
    {
        public void timuoc(int n)
        {
               
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        txtkq.Text += i + " ";
                    }
                }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                int n = Convert.ToInt32(txtn.Text);
                timuoc(n);
            }
            else
            {
                MessageBox.Show("Please input n");
                txtn.Focus();
            }
        }
    }
}
