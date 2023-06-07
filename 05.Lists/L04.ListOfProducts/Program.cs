﻿using System;
using System.Collections.Generic;

namespace L04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < numberOfItems; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
