using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigure
{
   public class Rectangle
    {
        public static void Square(double A, double B)
        {
            var SQR = A * B;
            Console.WriteLine($"Площадь четырехугольника со сторонами A = {A}, B = {B} равна {SQR}");
        }
    }
}
