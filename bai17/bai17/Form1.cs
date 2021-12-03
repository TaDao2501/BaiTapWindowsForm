using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai17
{
    public partial class Form1 : Form
    {
        int[] key;
        public void mahoa()
        { 
                string s=txtbanro.Text;
                char[] arr = s.ToCharArray();
                key = new int[arr.Length];
                string kq="";
                for(int i=0;i<arr.Length;i++)
                {
                    int temp=Convert.ToInt32(arr[i]);
                    kq += temp+" ";
                    key[i] = temp;
                }
                txtbanma2.Text = kq;
        }
        public void giaima()
        {
            string plain = "";
            for (int i = 0; i < key.Length; i++)
            {
                plain += key[i].ToString();
            }
            txtbanro.Text = plain;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbanro.Text != "")
            {
                mahoa();
            }
            else
            {
                MessageBox.Show("Không được để trống");
                txtbanro.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbanma2.Text != "")
            {
                giaima();
            }
            else
            {
                MessageBox.Show("Chưa có bản mã");
                txtbanro.Focus();
            }
        }
    }
}
