using System;
using System.Collections.Generic;
using System.Linq;

namespace L06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" ");
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Item item = new Item(itemName, price);
                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);
            }
            
            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string itemName, decimal price)
        {
            Name = itemName;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }
        public Item Item  { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice => Quantity * Item.Price;
    }
}
