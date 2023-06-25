using System;

namespace E01.TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingBiscuits = int.Parse(Console.ReadLine());
            double totalBiscuitsPerDay = biscuitsPerDay * workers;
            int days = 1;
            double totalBiscuits = 0;
            while (days <= 30)
            {
                if (days % 3 != 0)
                {
                    totalBiscuits += totalBiscuitsPerDay;
                }
                else
                {
                    totalBiscuits += Math.Floor(totalBiscuitsPerDay * 0.75);
                }

                days++;
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            double difference = totalBiscuits - competingBiscuits;
            double percentage = Math.Abs(difference/competingBiscuits) * 100;
            if (competingBiscuits - totalBiscuits > 0)
            {
                Console.WriteLine($"You produce {percentage:F2} percent less biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
            }
        }
    }
}
