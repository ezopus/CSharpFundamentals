using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> output = new List<string>();
            for (int i = arrayString.Length - 1; i >= 0; i--)
            {
                string[] temp = arrayString[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                output.AddRange(temp);
            }

            Console.WriteLine(string.Join(' ', output));
           
        }

    }
}
