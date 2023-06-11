using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateship = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            List<int> warship = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string input = "";
            bool sunkWarship = false;
            bool sunkPirateship = false;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Fire":
                        int fireIndex = int.Parse(commands[1]);
                        int damage = int.Parse(commands[2]);
                        if (FireAtShip(warship, fireIndex, damage))
                        {
                            sunkWarship = true;
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        damage = int.Parse(commands[3]);
                        if (DefendShip(pirateship, startIndex, endIndex, damage))
                        {
                            sunkPirateship = true;
                        }
                        break;
                    case "Repair":
                        int repairIndex = int.Parse(commands[1]);
                        int health = int.Parse(commands[2]);
                        RepairShip(pirateship, repairIndex, health, maxHealth);
                        break;
                    case "Status":
                        Status(pirateship, maxHealth);
                        break;

                    default:
                        break;
                }

                if (sunkWarship)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    break;
                }

                if (sunkPirateship)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    break;
                }
            }

            if (!sunkPirateship && !sunkWarship)
            {
                Console.WriteLine($"Pirate ship status: {Sum(pirateship)}");
                Console.WriteLine($"Warship status: {Sum(warship)}");
            }


        }

        private static int Sum(List<int> ship)
        {
            int sum = 0;
            foreach (int shipSection in ship)
            {
                sum += shipSection;
            }
            return sum;
        }

        static void Status(List<int> pirateship, int maxHealth)
        {
            int neededRepairs = 0;
            foreach (int section in pirateship)
            {
                if (section < (double)maxHealth * 0.2)
                {
                    neededRepairs++;
                }
            }

            Console.WriteLine($"{neededRepairs} sections need repair.");
        }

        static List<int> RepairShip(List<int> pirateship, int repairIndex, int health, int maxHealth)
        {
            if (repairIndex >= 0 && repairIndex < pirateship.Count)
            {
                if (pirateship[repairIndex] + health > maxHealth)
                {
                    pirateship[repairIndex] = maxHealth;
                }
                else
                {
                    pirateship[repairIndex] += health;
                }
            }
            return pirateship;
        }

        static bool DefendShip(List<int> pirateship, int startIndex, int endIndex, int damage)
        {
            if (startIndex >= 0 && startIndex < pirateship.Count && endIndex >= 0 && endIndex < pirateship.Count)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (pirateship[i] - damage <= 0)
                    {
                        return true;
                    }
                    else
                    {
                        pirateship[i] -= damage;
                    }
                }
            }
            return false;
        }

        static bool FireAtShip(List<int> warship, int fireIndex, int damage)
        {
            if (fireIndex >= 0 && fireIndex < warship.Count)
            {
                if (warship[fireIndex] - damage <= 0)
                {
                    return true;
                }
                else
                {
                    warship[fireIndex] -= damage;
                }
            }
            return false;
        }
    }
}
