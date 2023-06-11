using System;
using System.Collections.Generic;
using System.Linq;


namespace E02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split('!')
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Urgent":
                        string urgentItem = commands[1];
                        shoppingList = Urgent(shoppingList, urgentItem);
                        break;
                    case "Unnecessary":
                        string unnecessaryItem = commands[1];
                        shoppingList = Unnecessary(shoppingList, unnecessaryItem);
                        break;
                    case "Correct":
                        string oldItem = commands[1];
                        string newItem = commands[2];
                        shoppingList = Correct(shoppingList, oldItem, newItem);
                        break;
                    case "Rearrange":
                        string rearrangeItem = commands[1];
                        shoppingList = Rearrange(shoppingList, rearrangeItem);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }

        private static List<string> Rearrange(List<string> shoppingList, string rearrangeItem)
        {
            if (shoppingList.Contains(rearrangeItem))
            {
                int index = shoppingList.IndexOf(rearrangeItem);
                shoppingList.RemoveAt(index);
                shoppingList.Add(rearrangeItem);
            }
            return shoppingList;
        }

        private static List<string> Correct(List<string> shoppingList, string oldItem, string newItem)
        {
            if (shoppingList.Contains(oldItem))
            {
                int index = shoppingList.IndexOf(oldItem);
                shoppingList[index] = newItem;
            }
            return shoppingList;
        }

        private static List<string> Unnecessary(List<string> shoppingList, string unnecessaryItem)
        {
            if (shoppingList.Contains(unnecessaryItem))
            {
                shoppingList.Remove(unnecessaryItem);
            }
            return shoppingList;
        }

        private static List<string> Urgent(List<string> shoppingList, string urgentItem)
        {
            if (!shoppingList.Contains(urgentItem))
            {
                shoppingList.Insert(0, urgentItem);
            }
            return shoppingList;
        }

    }
}
