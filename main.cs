using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_4
{
    class main
    {
        static void Main(string[] args)
        {
            Hinh tamgiac = new Tamgiac();
            Console.WriteLine("Chu vi = {0} Va Dien tich= {1} Hinh tamg giac ", tamgiac.GetChuvi(), tamgiac.GetDientich());
            Hinh hinhtron = new Hinhtron();
            Console.WriteLine("Chu vi = {0} Va Dien tich= {1} Hinh tron  ", hinhtron.GetChuvi(), hinhtron.GetDientich());
            Hinh hinhchunhat = new Hinhchunhat();
            Console.WriteLine("Chu vi = {0} Va Dien tich= {1} Hinh chu nhat  ", hinhchunhat.GetChuvi(), hinhchunhat.GetDientich());

            NhapHinh nhap = new NhapHinh();
            nhap.NhapDanhsach();
            Console.WriteLine("Hinh co dien tich lon nhat la : " + nhap.Kiemtra());
            Console.WriteLine("Tong chu vi cua cac hinh la : " + nhap.Tinhtongchuvi());
            Console.ReadKey();
        }
    }
}
