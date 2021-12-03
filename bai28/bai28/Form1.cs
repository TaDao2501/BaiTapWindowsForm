using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bai28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool kiemtra(string date)
        {
            char[] s = date.ToCharArray();
            bool check = true;
            if (s[2] == '/' && s[5] == '/')
            {
                int s1 = Convert.ToInt32(date.Substring(0, 2));
                int s2 = Convert.ToInt32(date.Substring(3, 2));
                int s3 = Convert.ToInt32(date.Substring(6, 4));
                if (s2 == 2)
                {
                    if (s1 < 0 || s1 > 29)
                    {
                        MessageBox.Show("Sai gia tri ngay");
                        check = false;
                    }
                    else if (s2 < 0 || s1 > 12)
                    {
                        MessageBox.Show("Sai gia tri thang");
                        check = false;
                    }
                }
                else if (s2 == 1 || s2 == 3 || s2 == 5 || s2 == 7 || s2 == 8 || s2 == 10 || s2 == 12)
                {
                    if (s1 < 0 || s1 > 31)
                    {
                        MessageBox.Show("Sai gia tri ngay");
                        check = false;
                    }
                    else if (s2 < 0 || s1 > 12)
                    {
                        MessageBox.Show("Sai gia tri thang");
                        check = false;
                    }
                }
                else if (s2 == 4 || s2 == 6 || s2 == 9 || s2 == 11)
                {
                    if (s1 < 0 || s1 > 30)
                    {
                        MessageBox.Show("Sai gia tri ngay");
                        check = false;
                    }
                    else if (s2 < 0 || s1 > 12)
                    {
                        MessageBox.Show("Sai gia tri thang");
                        check = false;
                    }
                }
            }
             return check;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtms.Text != "" && txthoten.Text != "" && txtns.Text != "")
            {
                string ten = txthoten.Text;
                string ms = txtms.Text;
                string ns = txtns.Text;
               
                if (saveFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    File.AppendAllText(saveFileDialog1.FileName, ms + " " + ten + " " + ns + Environment.NewLine);
                }
                
            }
            else
            {
                MessageBox.Show("Nhap day du thong tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] s = line.Split(' ');
                    ListViewItem item = new ListViewItem(s);
                    listView1.Items.Add(item);

                }
            }
        }
    }
}
