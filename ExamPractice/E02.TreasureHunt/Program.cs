using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine()
                .Split('|')
                .ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Loot":
                        List<string> lootItems = new List<string>();
                        for (int i = 1; i < commands.Length; i++)
                        {
                            lootItems.Add(commands[i]);
                        }
                        chest = LootItems(chest, lootItems);
                        break;
                    case "Drop":
                        int dropIndex = int.Parse(commands[1]);
                        chest = DropItem(chest, dropIndex);
                        break;
                    case "Steal":
                        int stolenCount = int.Parse(commands[1]);
                        chest = Steal(chest, stolenCount);
                        break;

                    default:
                        break;
                }
            }

            double itemCount = 0;
            double itemLength = 0;
            foreach (string item in chest)
            {
                itemCount++;
                itemLength += item.Length;
            }
            double averageGain = itemLength / itemCount;

            if (chest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static List<string> Steal(List<string> chest, int stolenCount)
        {
            List<string> stolen = new List<string>();
            int stolenCounter = 0;
            while (stolenCounter < stolenCount && chest.Count > 0)
            {
                string stolenItem = chest[chest.Count - 1];
                stolen.Add(stolenItem);
                chest.RemoveAt(chest.Count - 1);
                stolenCounter++;
            }
            stolen.Reverse();
            Console.WriteLine(string.Join(", ", stolen));
            return chest;
        }

        private static List<string> DropItem(List<string> chest, int dropIndex)
        {
            if (dropIndex >= 0 && dropIndex < chest.Count)
            {
                string droppedItem = chest[dropIndex];
                chest.RemoveAt(dropIndex);
                chest.Add(droppedItem);
            }
            return chest;
        }

        private static List<string> LootItems(List<string> chest, List<string> lootItems)
        {
            for (int i = 0; i < lootItems.Count; i++)
            {
                if (!chest.Contains(lootItems[i]))
                {
                    chest.Insert(0, lootItems[i]);
                }
            }
            return chest;
        }
    }
}
