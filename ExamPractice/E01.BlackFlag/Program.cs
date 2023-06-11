using System;

namespace E01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double perDay = int.Parse(Console.ReadLine());
            double expectedPlunder = int.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += perDay;
                if (i % 3 == 0)
                {
                    totalPlunder += perDay / 2;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= (1 - 0.3);
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder/expectedPlunder*100:f2}% of the plunder.");
            }
        }
    }
}
