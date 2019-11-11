using System;


namespace MyFigure
{
    public class Circle
    {
        public static void Squre(double Radius)
        {
            var SQR = (Math.PI) * (Math.Pow(Radius,2));
            Console.WriteLine($"Площадь круга с радиусом {Radius} равна {SQR}");
        }
    }
}
