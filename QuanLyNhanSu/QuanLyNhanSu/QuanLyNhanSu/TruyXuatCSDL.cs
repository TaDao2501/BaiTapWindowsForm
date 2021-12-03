using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    static  class TruyXuatCSDL
    {
        private static string DuongDan = @"Data Source=DESKTOP-S6B8V6U\;Initial Catalog=qlnhansu;Integrated Security=True";
        // lấy ra một danh sách
        public static ArrayList LayDanhSach(string sql)
        {
            DataTable b = LayBang(sql);
            ArrayList kq = new ArrayList();
            for (int i = 0; i < b.Rows.Count; i++)
                kq.Add(b.Rows[i][0].ToString());
            return kq;
        }
        // lấy ra một giá trị
        public static string LayMotGiaTri(string sql)
        {
            SqlConnection DuongOng = TaoDuongOng();
            DuongOng.Open();
            SqlCommand Lenh = new SqlCommand(sql, DuongOng);
            object kq = Lenh.ExecuteScalar();
            if (kq == null)
                return "";
            else
                return kq.ToString();
        }

        private static SqlConnection TaoDuongOng()
        {
            return new SqlConnection(DuongDan);
        }
         
        // lấy ra một bảng dữ liệu
        public static DataTable LayBang(string sql)
        {
            SqlConnection OngDan = TaoDuongOng();
            OngDan.Open();
            SqlDataAdapter MayBom = new SqlDataAdapter(sql, OngDan);
            DataTable ThungChua = new DataTable();
            MayBom.Fill(ThungChua);
            OngDan.Close();
            MayBom.Dispose();
            return ThungChua;
                 
        }
        // phương thức thêm sửa xóa
        public static void ThemSuaXoa(string sql)
        {
            SqlConnection OngDan = TaoDuongOng();
            OngDan.Open();
            SqlCommand Lenh = new SqlCommand(sql, OngDan);
            Lenh.ExecuteNonQuery();
            OngDan.Close();
            Lenh.Dispose();
        }
    }
}
