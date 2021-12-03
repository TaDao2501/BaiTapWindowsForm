using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdl.Text != "")
            {
                try{
                    int nam=Convert.ToInt32(txtdl.Text);
                string kq = "";
                switch (nam % 10)
                {
                    case 0:
                        kq += "Canh";
                        break;
                    case 1:
                        kq += "Tân";
                        break;
                    case 2:
                        kq += "Nhâm";
                        break;
                    case 3:
                        kq += "Quý";
                        break;
                    case 4:
                        kq += "Giáp";
                        break;
                    case 5:
                        kq += "Ất";
                        break;
                    case 6:
                        kq += "Bính";
                        break;
                    case 7:
                        kq += "Đinh";
                        break;
                    case 8:
                        kq += "Mậu";
                        break;
                    case 9:
                        kq += "Kỷ";
                        break;
                }
                switch (nam % 12)
                {
                    case 0:
                        kq += " Thân";
                        break;
                    case 1:
                        kq += " Dậu";
                        break;
                    case 2:
                        kq += " Tuất";
                        break;
                    case 3:
                        kq += " Hợi";
                        break;
                    case 4:
                        kq += " Tí";
                        break;
                    case 5:
                        kq += " Sửu";
                        break;
                    case 6:
                        kq += " Dần";
                        break;
                    case 7:
                        kq += " Mão";
                        break;
                    case 8:
                        kq += " Thìn";
                        break;
                    case 9:
                        kq += " Tị";
                        break;
                    case 10:
                        kq += " Ngọ";
                        break;
                    case 11:
                        kq += " Mùi";
                        break;
                }
                txtal.Text = kq;
                }catch(Exception ex)
                {
                    MessageBox.Show("Sai định dạng năm");
                    txtdl.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập năm dương lịch đã");
                txtdl.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdl.Focus();
        }
    }
}
