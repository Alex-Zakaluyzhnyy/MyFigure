using System;


namespace MyFigure
{
    public class Triangle
    {
        public static void Square(double A, double B, double C)
        {
            var P = (A + B + C)*0.5;
            var SQR = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            Console.WriteLine($"Площадь треугольника со сторонами A = {A}, B = {B}, C = {C} равна {SQR}");
        }

        public static bool IsRightTriangle(double A, double B, double C)
        {
            if ((Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
