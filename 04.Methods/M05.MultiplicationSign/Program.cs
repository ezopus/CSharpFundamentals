using System;
using System.Numerics;

namespace M05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            CheckSign(first, second, third);
        }

        static void CheckSign(int first, int second, int third)
        {
            int numberOfNegatives = 0;

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (first < 0) numberOfNegatives++;
            if (second < 0) numberOfNegatives++;
            if (third < 0) numberOfNegatives++;
            if (numberOfNegatives % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}