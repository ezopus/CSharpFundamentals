using System;
using System.Numerics;

namespace M04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Tribonacci(number);
        }

        static void Tribonacci(long number)
        {

            long n1 = 0;
            long n2 = 0;
            long n3 = 1;
            if (number > 0)
            {
                Console.Write(1 + " ");
            }
            for (long i = number; i > 1; --i)
            {
                long num = n1 + n2 + n3;
                Console.Write(num + " ");
                n1 = n2;
                n2 = n3;
                n3 = num;
            }
        }
    }
}