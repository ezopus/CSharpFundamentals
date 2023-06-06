using System;

namespace M02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            FindCenterPoint(X1, Y1, X2, Y2);
        }

        static void FindCenterPoint(double x1, double y1, double x2, double y2)
        {
            double hypothenuse1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double hypothenuse2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (hypothenuse1 > hypothenuse2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
