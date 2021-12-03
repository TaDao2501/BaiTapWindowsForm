using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap()
        {
            if ((txtID.Text.Trim() == "") || (txtPassword.Text.Trim() == ""))
                MessageBox.Show("Chưa nhập đủ thông tin tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string loai = TruyXuatCSDL.LayMotGiaTri(" select loai from tbAccount where ID =N'" +
                    txtID.Text + "' and password =N'" +
                    txtPassword.Text + "'");
                if (loai == "")
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Form1 frmMain = new Form1(loai);
                    frmMain.Show();
                    this.Hide();

                }


            }
        }
             
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DangNhap();
        }
    }
}
