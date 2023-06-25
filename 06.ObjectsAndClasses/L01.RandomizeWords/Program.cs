using System;
using System.Linq;

namespace L01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);
                string currentIndex = input[i];
                string randomReplacement = input[randomIndex];
                input[i] = randomReplacement;
                input[randomIndex] = currentIndex;
            }

            foreach (string s in input)
            {
                Console.WriteLine(s);
            }
        }
    }
}

