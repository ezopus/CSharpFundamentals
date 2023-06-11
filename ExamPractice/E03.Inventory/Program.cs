using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ");
                switch (commands[0])
                {
                    case "Collect":
                        string item = commands[1];
                        CollectItem(items, item);
                        break;
                    case "Drop":
                        item = commands[1];
                        DropItem(items, item);
                        break;
                    case "Combine Items":
                        string[] separateItems = commands[1].Split(":");
                        string oldItem = separateItems[0];
                        string newItem = separateItems[1];
                        CombineItems(items, oldItem, newItem);
                        break;
                    case "Renew":
                        item = commands[1];
                        RenewItem(items, item);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }

        private static void RenewItem(List<string> items, string item)
        {
            if (items.Contains(item))
            {
                int index = items.IndexOf(item);
                items.RemoveAt(index);
                items.Add(item);
            }
        }

        private static List<string> CombineItems(List<string> items, string oldItem, string newItem)
        {
            if (items.Contains(oldItem))
            {
                int indexOldItem = items.IndexOf(oldItem);
                items.Insert(indexOldItem + 1, newItem);
            }
            return items;
        }

        private static List<string> DropItem(List<string> items, string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }
            return items;
        }

        private static List<string> CollectItem(List<string> items, string item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
            }
            return items;
        }
    }
}
