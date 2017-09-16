using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_4
{
    class Hinhtron : Hinh
    {
        double bankinh;
        public Hinhtron()
        {
            bankinh = 5.2;
        }
        public Hinhtron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public override double GetChuvi()
        {
            return 2 * bankinh * 3.14;
        }
        public override double GetDientich()
        {
            return 3.14 * bankinh * bankinh;
        }
        public override void Nhap()
        {
            Console.Write("Nhap ban kinh: "); bankinh = Convert.ToDouble(Console.ReadLine());
        }
    }
}
