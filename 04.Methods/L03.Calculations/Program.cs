using System;

namespace L03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add": 
                    Add(numberOne, numberTwo);
                    break;
                case "multiply":
                    Multiply(numberOne, numberTwo);
                    break;
                case "subtract":
                    Subtract(numberOne, numberTwo);
                    break;
                case "divide":
                    Divide(numberOne, numberTwo);
                    break;
                default:
                    break;
            }
        }

        static void Add(int one, int two)
        {
            Console.WriteLine(one + two);
        }

        static void Multiply(int one, int two)
        {
            Console.WriteLine(one * two);
        }

        static void Subtract(int one, int two)
        {
            Console.WriteLine(one - two);
        }

        static void Divide(int one, int two)
        {
            Console.WriteLine(one / two);
        }
    }
}
