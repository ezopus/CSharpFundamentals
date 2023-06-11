using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace E02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                .Split('|')
                .ToList();
            int health = 100;
            int bitcoins = 0;
            List<string> roomType = new List<string>();
            List<int> roomValue = new List<int>();
            foreach (string s in rooms)
            {
                string[] oneRoom = s.Split(" ");
                roomType.Add(oneRoom[0]);
                roomValue.Add(int.Parse(oneRoom[1]));
            }

            bool isAlive = true;
            int bestRoom = 1;
            for (int i = 0; i < rooms.Count; i++)
            {
                if (roomType[i] == "potion")
                {
                    int potion = roomValue[i];
                    if (health + potion > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += potion;
                        Console.WriteLine($"You healed for {potion} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (roomType[i] == "chest")
                {
                    bitcoins += roomValue[i];
                    Console.WriteLine($"You found {roomValue[i]} bitcoins.");
                }
                else
                {
                    string monster = roomType[i];
                    int attack = roomValue[i];
                    if (health - attack <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        isAlive = false;
                        break;
                    }
                    else
                    {
                        health -= attack;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
                bestRoom++;
            }

            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
