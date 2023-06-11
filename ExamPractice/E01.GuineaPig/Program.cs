using System;
using System.Collections.Generic;

namespace E01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;
            int days = 1;
            while (days <= 30)
            {
                if (food < 0 || hay < 0 || cover < 0)
                {
                    break;
                }

                food -= 300;
                if (days % 2 == 0)
                {
                    hay -= food * 0.05;
                }

                if (days % 3 == 0)
                {
                    cover -= weight / 3;
                }

                days++;
            }

            if (food >= 0 && hay >= 0 && cover >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
