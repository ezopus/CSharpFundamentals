using System;
using System.Linq;

namespace E02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string input)
        {
            int sumVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'i':
                    case 'u':
                        sumVowels++;
                        break;
                    default:
                        break;
                }
            }
            return sumVowels;
        }
    }
}
