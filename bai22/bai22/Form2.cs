using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace bai22
{
    public partial class Form2 : Form
    {
        ArrayList arr;
        public Form2()
        {
            InitializeComponent();
            arr = new ArrayList();
        }

        private void txtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (txtn.Text != "")
                {
                    Random rd=new Random();
                    int n=Convert.ToInt32(txtn.Text);
                    for(int i=0;i<n;i++)
                    {
                        arr.Add(rd.Next(-100,100));
                    }
                    foreach (int x in arr)
                    {
                        txtchuoi.Text += x + " ";
                    }
                }
                else
                {
                    MessageBox.Show("Nhập n đã");
                    txtn.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1(arr).Show();
        }
    }
}
