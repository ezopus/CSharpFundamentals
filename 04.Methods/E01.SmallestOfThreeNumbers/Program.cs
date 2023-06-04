using System;

namespace E01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            SmallestOfThreeNumber(numberOne, numberTwo, numberThree);
        }

        private static void SmallestOfThreeNumber(int numberOne, int numberTwo, int numberThree)
        {
            int[] array = { numberOne, numberTwo, numberThree };
            Array.Sort(array);
            Console.WriteLine(array[0]);
        }
    }
}
