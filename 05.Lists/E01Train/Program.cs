using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    passengers.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = int.Parse(command[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (newPassengers + passengers[i] <= wagonCapacity)
                        {
                            passengers[i] += newPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", passengers));
        }
    }
}
