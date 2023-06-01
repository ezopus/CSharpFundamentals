using System;

namespace L07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numberOfRepeats = int.Parse(Console.ReadLine());
            StringRepeat(input, numberOfRepeats);
        }

        static void StringRepeat(string input, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(input);
            }
        }
    }
}
