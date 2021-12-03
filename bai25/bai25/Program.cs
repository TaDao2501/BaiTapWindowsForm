using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai25
{
    class CNhanVien
    {
        private string ho;
        private string ten;
        private int sosp;

        public CNhanVien(string ho,string ten,int sp)
        {
            this.ho = ho;
            this.ten = ten;
            if (sp < 0)
            {
                this.sosp = 0;
            }
            else
            {
                this.sosp = sp;
            }
        }

        public double TinhLuong()
        {
            double luong = 0;
            if (1 <= this.sosp && this.sosp <= 199)
            {
                luong = (this.sosp * 0.5);
            }
            else if (200 <= this.sosp && this.sosp <= 399)
            {
                luong = (this.sosp * 0.55);
            }
            else if (400 <= this.sosp && this.sosp <= 599)
            {
                luong = (this.sosp * 0.6);
            }
            else if (600 <= this.sosp )
            {
                luong = (this.sosp * 0.65);
            }
            return luong;
        }
        public bool LonHon(CNhanVien n2)
        {
            return this.sosp > n2.getsp();
        }
        public int getsp()
        {
            return this.sosp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap nhan vien");
            Console.WriteLine("Nhan vien thu 1: ");
            string ho1 = Console.ReadLine();
            string ten1 = Console.ReadLine();
            int sp1 = Convert.ToInt32(Console.ReadLine());
            CNhanVien nv1 = new CNhanVien(ho1, ten1, sp1);
            Console.WriteLine("Nhan vien thu 2: ");
            string ho2 = Console.ReadLine();
            string ten2 = Console.ReadLine();
            int sp2 = Convert.ToInt32(Console.ReadLine());
            CNhanVien nv2 = new CNhanVien(ho2, ten2, sp2);
            Console.WriteLine("Luong nhan vien 1 la: " + nv1.TinhLuong());
            Console.WriteLine("Luong nhan vien 2 la: " + nv2.TinhLuong());
            /*if (nv1.LonHon(nv2))
            {
                Console.WriteLine("Nhan vien 1 nhieu san pham hon va nhieu hon " + (nv1.getsp() - nv2.getsp())+" san pham");
            }
            else
            {
                Console.WriteLine("Nhan vien 2 nhieu san pham hon va nhieu hon " + (nv2.getsp() - nv1.getsp()) + " san pham");
            }*/
            if (nv1.getsp()>nv2.getsp())
            {
                Console.WriteLine("Nhan vien 1 nhieu san pham hon va nhieu hon " + (nv1.getsp() - nv2.getsp())+" san pham");
            }
            else
            {
                Console.WriteLine("Nhan vien 2 nhieu san pham hon va nhieu hon " + (nv2.getsp() - nv1.getsp()) + " san pham");
            }
            Console.ReadKey();
        }
    }
}
