using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ');
                switch (command[0])
                {
                    case "Shoot":
                        int index = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        targets = ShootTarget(targets, index, power);
                        break;
                    case "Add":
                        index = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        targets = AddTarget(targets, index, value);
                        break;
                    case "Strike":
                        index = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        targets = StrikeTarget(targets, index, radius);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static List<int> StrikeTarget(List<int> targets, int index, int radius)
        {
            int leftRange = index - radius;
            int rightRange = index + radius;
            if (leftRange >= 0 && leftRange < targets.Count && rightRange >= 0 && rightRange < targets.Count)
            {
                int rangeLength = rightRange - leftRange + 1;
                targets.RemoveRange(leftRange, rangeLength);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            return targets;
        }

        private static List<int> AddTarget(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
            return targets;
        }

        private static List<int> ShootTarget(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (targets[index] - power > 0)
                {
                    targets[index] -= power;
                }
                else
                {
                    targets.RemoveAt(index);
                }
            }
            return targets;
        }
    }
}
