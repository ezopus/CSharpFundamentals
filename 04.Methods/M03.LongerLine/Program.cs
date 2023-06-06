using System;

namespace M03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());
            double firstLine = LineLength(X1, Y1, X2, Y2);
            double secondLine = LineLength(X3, Y3, X4, Y4);
            double[] coordinates = new double[4];
            if (firstLine > secondLine)
            {
                FindCenterPoint(X1, Y1, X2, Y2);
            }
            else
            {
                FindCenterPoint(X3, Y3, X4, Y4);
            }

        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        static void FindCenterPoint(double x1, double y1, double x2, double y2)
        {
            double hypothenuse1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double hypothenuse2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (hypothenuse1 > hypothenuse2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

    }
}
