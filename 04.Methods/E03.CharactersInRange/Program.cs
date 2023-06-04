using System;

namespace E03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            CharsInRange(startChar, endChar);
        }

        private static void CharsInRange(char startChar, char endChar)
        {
            if ((int)startChar > (int)endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }
            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
