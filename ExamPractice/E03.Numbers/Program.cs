using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> output = new List<int>();
            double average = 0;

            foreach (int i in input)
            {
                average += i;
            }
            average /= input.Count;


            for (int i = 0; i < input.Count; i++)
            {
                if (average < input[i])
                {
                    output.Add(input[i]);
                }
            }
            output.Sort();
            output.Reverse();
            int outputCounter = 0;
            if (output.Count > 0)
            {
                foreach (int number in output)
                {
                    if (outputCounter < 5)
                    {
                        Console.Write(number + " ");
                        outputCounter++;
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
