using System;

namespace L08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(baseNumber, power));
            
        }

        static double MathPower(double baseNumber, int power)
        {
            return Math.Pow(baseNumber, power);
        }
    }
}
