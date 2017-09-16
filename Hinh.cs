using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_4
{
    class Hinh
    {
        public virtual double GetDientich()
        {
            return 0;
        }
        public virtual double GetChuvi()
        {
            return 0;
        }
        public virtual void Nhap()
        {

        }
    }
    class NhapHinh
    {
        Hinh[] danhsach = new Hinh[1000];
        public int n, m, j;
        public double a, b, c;
        public double S1 = 0, S2 = 0, S3 = 0;
        public void NhapDanhsach()
        {

            Console.Write("Nhap so luong hinh chu nhat  : "); n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hinh thu {0}", i + 1);
                danhsach[i] = new Hinhchunhat();
                danhsach[i].Nhap();
                a = danhsach[0].GetDientich();
                if (danhsach[i].GetDientich() < a)
                {
                    a = danhsach[i].GetDientich();
                }
                S1 += danhsach[i].GetChuvi();
            }

            Console.Write("Nhap so luong hinh tron : "); m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Hinh thu {0}", i + 1);
                danhsach[i] = new Hinhtron();
                danhsach[i].Nhap();
                b = danhsach[0].GetDientich();
                if (danhsach[i].GetDientich() < b)
                {
                    b = danhsach[i].GetDientich();
                }
                S2 += danhsach[i].GetChuvi();
            }

            Console.Write("Nhap so luong hinh tam giac  : "); j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Hinh thu {0}", i + 1);
                danhsach[i] = new Tamgiac();
                danhsach[i].Nhap();
                c = danhsach[0].GetDientich();
                if (danhsach[i].GetDientich() < c)
                {
                    c = danhsach[i].GetDientich();
                }
                S3 += danhsach[i].GetChuvi();
            }

        }

        public double Kiemtra()
        {
            double max;
            max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            return max;
        }
        public double Tinhtongchuvi()
        {
            return S1 + S2 + S3;
        }
    }
}
