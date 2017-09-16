using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_4
{
    class Tamgiac : Hinh
    {
        double a, b, c;
       public Tamgiac()
        {
            a = 0;
            b = 0;
            c = 0;
        }
       public Tamgiac(double a, double b, double c)
       {
           this.a = a;
           this.b = b;
           this.c = c;
       }
       public override double GetChuvi()
       {    
           return a+b+c ;
       }
       public override double GetDientich()
       {  
           double p = (a + b + c)/2;
           return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
       }

       public  override void Nhap()
       {
           Console.Write("Nhap canh a: "); a = Convert.ToDouble(Console.ReadLine());
           Console.Write("Nhap canh b: "); b = Convert.ToDouble(Console.ReadLine());
           Console.Write("Nhap canh c: "); c = Convert.ToDouble(Console.ReadLine());
           
       }
    }
}
