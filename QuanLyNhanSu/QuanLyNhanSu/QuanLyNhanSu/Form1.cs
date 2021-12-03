using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        private string loai;
        public Form1( string loai)
        {
            InitializeComponent();
            this.loai = loai;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu");
            dgv1.Columns[0].HeaderText = "Mã NV";
            dgv1.Columns[1].HeaderText = "Họ Tên";
            dgv1.Columns[2].HeaderText = "Địa Chỉ";
            dgv1.Columns[3].HeaderText = "Năm Sinh";
            dgv1.Columns[4].HeaderText = "Lương";

            dgv1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        if (loai=="1") // nhân vien
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        else if (loai=="0") // quản trị
            {
                MessageBox.Show("Đây là quản trị!", "Thông báo");

            }

            // lấy dữ liệu cho combobox
            
            ArrayList temp=    TruyXuatCSDL.LayDanhSach("select distinct diachi from nhansu");
            temp.Add("ALL");
            cbLoc.DataSource = temp;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into nhansu values('" +
                txtMaNV.Text + "', N'" +
                txtHoTen.Text + "', N'" +
                txtDiaChi.Text + "', " +
                txtNamSinh.Text + ", " +
                txtLuong.Text + ")";
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu");
            MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

        }

        private void dgv1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.CurrentRow!=null)
            {
                txtMaNV.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                txtNamSinh.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                txtLuong.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update nhansu set hoten = N'"+
                txtHoTen.Text+"', diachi = N'"+
                txtDiaChi.Text+"', namsinh = "+
                txtNamSinh.Text+", luong = "+
                txtLuong.Text+" where manv = N'"+
                txtMaNV.Text+"'";
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu");
            MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhansu where manv =N'" +
                txtMaNV.Text + "'";
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu");
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng chương trình này không",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq==DialogResult.Yes)
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbLuong.Font = new Font(lbLuong.Font, FontStyle.Bold|FontStyle.Italic|FontStyle.Underline);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoc.Text=="ALL")
                dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu");
            else
            dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu where diachi =N'" +
                cbLoc.Text + "'");
        }

        private void txtTKTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv1.DataSource = TruyXuatCSDL.LayBang("select * from nhansu where hoten like N'" +
                txtTKTen.Text + "%'");
            }
        }
    }
}
