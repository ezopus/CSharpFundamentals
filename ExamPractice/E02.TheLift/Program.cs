using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                if (peopleWaiting <= 0)
                {
                    break;
                }

                if (wagons[i] < 4)
                {
                    int freeSeats = Math.Min(4 - wagons[i], peopleWaiting);
                    if (freeSeats > 0)
                    {
                        wagons[i] += freeSeats;
                        peopleWaiting -= freeSeats;
                    }
                }
            }

            int totalPassengers = 0;
            foreach (int i in wagons)
            {
                totalPassengers += i;
            }

            if (peopleWaiting == 0 && wagons.Count * 4 - totalPassengers > 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (peopleWaiting == 0 && wagons.Count * 4 - totalPassengers == 0)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
