using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            if (txtHoLot.Text != "")
            {
                lblHoLot.Text = txtHoLot.Text;
            }
            else
            {
                MessageBox.Show("Họ lót bị trống!");
                txtHoLot.Focus();
            }
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                lblTen.Text = txtTen.Text;
            }
            else
            {
                MessageBox.Show("Tên bị trống!");
                txtTen.Focus();
            }
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            if (txtHoLot.Text != ""&&txtTen.Text!="")
            {
                lblHoVaTen.Text = txtHoLot.Text + " " + txtTen.Text;
            }
            else
            {
                MessageBox.Show("Họ lót và tên bị trống!");
                txtHoLot.Focus();
            }
        }

        private void lblHoVaTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoVaTen.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }
    }
}
