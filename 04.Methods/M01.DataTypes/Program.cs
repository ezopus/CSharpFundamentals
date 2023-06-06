using System;

namespace M01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var value = Console.ReadLine();
            switch (input)
            {
                case "int":
                    Operations(int.Parse(value));
                    break;
                case "real":
                    Operations(double.Parse(value));
                    break;
                case "string":
                    Operations(value);
                    break;
                default:
                    break;
            }
        }

        static void Operations(string value)
        {
            Console.WriteLine($"${value}$");
        }
        static void Operations(double value)
        {
            Console.WriteLine($"{value * 1.5:F2}");
        }

        static void Operations(int value)
        {
            Console.WriteLine(value * 2);
        }
    }
}
