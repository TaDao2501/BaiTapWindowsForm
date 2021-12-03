using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai24
{
    class CHinhTamGiac
    {
        private int ma;
        private int mb;
        private int mc;

        public CHinhTamGiac()
        {
        }
        public CHinhTamGiac(int ma,int mb,int mc)
        {
            if (LaTamGiac(ma,mb,mc))
            {
                this.ma = ma;
                this.mb = mb;
                this.mc = mc;
            }
            else
            {
                Console.WriteLine("Khong phai tam giac");
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }

        }
        public void seta(int a)
        {
            this.ma = a;
        }
        public void setb(int b)
        {
            this.mb = b;
        }
        public void setc(int c)
        {
            this.mc = c;
        }
        public int geta()
        {
            return this.ma;
        }
        public int getb()
        {
            return this.mb;
        }
        public int getc()
        {
            return this.mc;
        }
        public int ChuVi()
        {
            return ma + mb + mc;
        }
        public int DienTich()
        {
            int cv = ma + mb + mc;
            return (int)Math.Sqrt(cv * (cv - ma) * (cv - mb) * (cv - mc));
        }
        public bool LaTamGiac(int ma, int mb, int mc)
        {
            return ma + mb > mc && ma + mc > mb && mb + mc > ma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Nhap 3 canh tam giac: ");
            Console.WriteLine("Canh a: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            CHinhTamGiac tamgiac = new CHinhTamGiac(a, b, c);
            Console.WriteLine("Chu vi la: " + tamgiac.ChuVi());
            Console.WriteLine("Dien tich la: " + tamgiac.DienTich());
            Console.ReadKey();
        }
    }
}
