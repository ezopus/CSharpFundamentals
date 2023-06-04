using System;
using System.Linq;

namespace E11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "exchange":
                        initialArray = ExchangeArray(int.Parse(command[1]), initialArray);
                        break;
                    case "max":
                        MaxEvenOdd(command[1], initialArray);
                        break;
                    case "min":
                        MinEvenOdd(command[1], initialArray);
                        break;
                    case "first":
                        FirstCount(int.Parse(command[1]), command[2], initialArray);
                        break;
                    case "last":
                        LastCount(int.Parse(command[1]), command[2], initialArray);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }

        static int[] FirstCount(int firstOrLastCount, string typeEvenOdd, int[] initialArray)
        {
            if (firstOrLastCount >= initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            int counter = 0;
            while (firstOrLastCount > 0 && counter < initialArray.Length)
            {
                if (EvenOdd(typeEvenOdd, initialArray, counter))
                {
                    temp += initialArray[counter] + ", ";
                    firstOrLastCount--;
                }
                counter++;
            }
            if (temp != "")
            {
                Console.WriteLine($"[{temp.Trim(' ', ',')}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
            return initialArray;
        }

        static int[] LastCount(int firstOrLastCount, string typeEvenOdd, int[] initialArray)
        {
            if (firstOrLastCount >= initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                if (firstOrLastCount == 0)
                {
                    break;
                }
                if (EvenOdd(typeEvenOdd, initialArray, i))
                {
                    temp += initialArray[i] + ", ";
                    firstOrLastCount--;
                }
            }
            if (temp != "")
            {
                Console.WriteLine($"[{temp.Trim(' ', ',')}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
            return initialArray;
        }

        static void MaxEvenOdd(string typeMinOrMax, int[] initialArray)
        {
            int maxValue = int.MinValue;
            int maxIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (EvenOdd(typeMinOrMax, initialArray, index))
                {
                    if (initialArray[index] >= maxValue)
                    {
                        maxValue = initialArray[index];
                        maxIndex = index;
                    }
                }
            }
            if (maxIndex >= 0)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinEvenOdd(string typeMinOrMax, int[] initialArray)
        {
            int minValue = int.MaxValue;
            int minIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (EvenOdd(typeMinOrMax, initialArray, index))
                {
                    if (initialArray[index] <= minValue)
                    {
                        minValue = initialArray[index];
                        minIndex = index;
                    }
                }
            }

            if (minIndex >= 0)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        private static bool EvenOdd(string typeMinOrMax, int[] initialArray, int index)
        {
            if ((typeMinOrMax == "even" && initialArray[index] % 2 == 0) || (typeMinOrMax == "odd" && initialArray[index] % 2 != 0))
            {
                return true;
            }
            return false;
        }

        static int[] ExchangeArray(int exchangeIndex, int[] initialArray)
        {
            if (exchangeIndex >= initialArray.Length)
            {
                Console.WriteLine("Invalid index");
                return initialArray;
            }
            int[] newArray = new int[initialArray.Length];
            int newArrayIndex = 0;
            for (int i = exchangeIndex + 1; i < initialArray.Length; i++)
            {
                newArray[newArrayIndex] = initialArray[i];
                newArrayIndex++;
            }

            for (int i = 0; i <= exchangeIndex; i++)
            {
                newArray[newArrayIndex] = initialArray[i];
                newArrayIndex++;
            }
            return newArray;
        }
    }
}
