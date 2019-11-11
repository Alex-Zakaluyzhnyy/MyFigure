using System;


namespace MyFigure
{
    public class Circle
    {
        public static void Squre(double Radius)
        {
            var SQR = 2 * (Math.PI) * Radius;
            Console.WriteLine($"Площадь круга с радиусом {Radius} равна {SQR}");
        }
    }
}
