using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_4
{
    class Hinhchunhat : Hinh
    {
        double chieudai, chieurong;
        public Hinhchunhat()
        {
            chieudai = 5;
            chieurong = 9;
        }
        public Hinhchunhat(double Chieudai, double chieudai)
        {
            this.chieurong = chieurong;
            this.chieudai = chieudai;
        }
        public override double GetChuvi()
        {
            return (chieudai + chieurong) * 2;
        }
        public override double GetDientich()
        {
            return chieudai * chieurong;
        }

        public override void Nhap()
        {
            Console.Write("Nhap chieu dai: "); chieudai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: "); chieurong = Convert.ToDouble(Console.ReadLine());
        }
    }
}
