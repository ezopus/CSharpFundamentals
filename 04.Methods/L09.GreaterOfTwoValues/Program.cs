using System;

namespace L09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var typeValue = Console.ReadLine();
            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();
            Console.WriteLine(GetMax(inputOne, inputTwo));

        }
        static int GetMax(int one, int two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
            
        }
        static char GetMax(char one, char two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }
        static string GetMax(string one, string two)
        {
            

            if (one.Length > two.Length)
            {
                return one;
            }
            else return two;
        }
    }
}
