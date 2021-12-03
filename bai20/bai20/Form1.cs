using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtten.Text != "")
            {
                if (cbonhom.SelectedItem.Equals("Nhóm 1"))
                {
                    nhom1.Items.Add(txtten.Text);
                    tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
                }
                else
                {
                    nhom2.Items.Add(txtten.Text);
                    tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
                }
            }
            else
            {
                MessageBox.Show("Nhập họ tên");
                txtten.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nhom1.SelectedItem != null)
            {
                nhom2.Items.Add(nhom1.SelectedItem);
                nhom1.Items.Remove(nhom1.SelectedItem);
                tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
                tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên nào");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nhom2.SelectedItem != null)
            {
                nhom1.Items.Add(nhom2.SelectedItem);
                nhom2.Items.Remove(nhom2.SelectedItem);
                tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
                tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên nào");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string item in nhom1.Items)
            {
                nhom2.Items.Add(item);
            }
            nhom1.Items.Clear();
            tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
            tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in nhom2.Items)
            {
                nhom1.Items.Add(item);
            }
            nhom2.Items.Clear();
            tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
            tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nhom1.SelectedItem != null)
            {
                nhom1.Items.Remove(nhom1.SelectedItem);
                tongnhom1.Text = "Tổng số : " + nhom1.Items.Count;
            }
            else if (nhom2.SelectedItem != null)
            {
                nhom2.Items.Remove(nhom2.SelectedItem);
                tongnhom2.Text = "Tổng số : " + nhom2.Items.Count;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên nào");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
