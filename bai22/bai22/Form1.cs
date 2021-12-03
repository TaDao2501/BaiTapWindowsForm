using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace bai22
{
    public partial class Form1 : Form
    {
        ArrayList list;
        public Form1(ArrayList arr)
        {
            InitializeComponent();
            this.list = arr;
            if (list != null)
            {
                foreach (int x in list)
                {
                    txtmang.Text += x + " ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = File.CreateText(saveFileDialog1.FileName);
                writer.Write(txtmang.Text);
                writer.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int x in list)
            {
                tong += x;
            }
            MessageBox.Show("Tổng mảng là : " + tong);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           list.Sort();
            MessageBox.Show("Max là : "+(int)list[list.Count-1]+","+"Min là : " + (int)list[0]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in list)
            {
                if (x % 2 == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show("Các phần tử chẵn : " + dem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in list)
            {
                if (x % 2 != 0)
                {
                    dem++;
                }
            }
            MessageBox.Show("Các phần tử lẻ : " + dem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string vt = "";
            foreach (int x in list)
            {
                if (x % 2 == 0)
                {
                    vt+=list.IndexOf(x)+" ";
                }
            }
            MessageBox.Show("Vị trí phần tử chẵn : " + vt);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vt = "";
            foreach (int x in list)
            {
                if (x % 2 != 0)
                {
                    vt += list.IndexOf(x) + " ";
                }
            }
            MessageBox.Show("Vị trí phần tử lẻ : " + vt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
