using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbourhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string input = "";
            int houseIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] jumpCommand = input.Split();
                int jumpLength = int.Parse(jumpCommand[1]);
                SingleJump(neighbourhood, jumpLength, ref houseIndex);


            }

            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            bool isMissionSuccessful = true;
            int failedHouses = 0;
            foreach (int i in neighbourhood)
            {
                if (i != 0)
                {
                    isMissionSuccessful = false;
                    failedHouses++;
                }
            }

            if (failedHouses > 0 && !isMissionSuccessful)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }

        private static void SingleJump(List<int> neighbourhood, int jumpLength, ref int houseIndex)
        {
            houseIndex += jumpLength;
            if (houseIndex >= neighbourhood.Count)
            {
                houseIndex = 0;
            }
            if (neighbourhood[houseIndex] != 0)
            {
                neighbourhood[houseIndex] -= 2;
                if (neighbourhood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                }
            }
            else
            {
                Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
            }
        }
    }
}
