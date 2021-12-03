using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listnumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 15; i++)
            {
                listnumber.Items.Add(i);
            }
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "")
            {
                try
                {
                    int n = Convert.ToInt32(txtn.Text);
                    if (listnumber.Items.IndexOf(txtn.Text.Trim()) >= 0)
                    {
                        MessageBox.Show("So da ton tai");
                        txtn.Focus();
                    }
                    else
                    {
                        listnumber.Items.Add(n);
                        txtn.Clear();
                        txtn.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai định dạng n");
                    txtn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập n");
                txtn.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i <= listnumber.Items.Count; i++)
            {
                tong += Convert.ToInt32(listnumber.GetItemText(i));
            }
            MessageBox.Show("Tổng phần tử danh sách :"+tong);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listnumber.Items.Count>0)
            listnumber.Items.RemoveAt(0);
            if (listnumber.Items.Count > 0)
            listnumber.Items.RemoveAt(listnumber.Items.Count - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while  (listnumber.SelectedItems.Count>0)
            {
                listnumber.Items.Remove(listnumber.SelectedItem);
            }
            /*else
            {
                MessageBox.Show("Chưa chọn phần tử");
            }*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listnumber.Items.Count; i++)
            {
               int v = Convert.ToInt32(listnumber.Items[i]);
                v +=2;
                listnumber.Items[i] = v.ToString();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listnumber.Items.Count; i++)
            {
                long v = long.Parse(listnumber.Items[i].ToString());
                v *= v;
                listnumber.Items[i] = v.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listnumber.Items.Count; i++)
            {
               if(Convert.ToInt32(listnumber.Items[i])%2==0)
               {
                   listnumber.SelectedItems.Add(listnumber.Items[i]);
               }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listnumber.Items.Count; i++)
            {
                if (Convert.ToInt32(listnumber.Items[i]) % 2 != 0)
                {
                    listnumber.SelectedItems.Add(listnumber.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
