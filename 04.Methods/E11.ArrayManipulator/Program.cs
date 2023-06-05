using System;
using System.Linq;
using System.Reflection;

namespace E11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] initialArray = Console.ReadLine()
                .Split()
                .Select(long.Parse)
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
                        int count = int.Parse(command[1]);
                        string type = command[2];
                        FirstCount(count, type, initialArray);
                        break;
                    case "last":
                        count = int.Parse(command[1]);
                        type = command[2];
                        LastCount(count, type, initialArray);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }

        static long[] FirstCount(int count, string typeEvenOdd, long[] initialArray)
        {
            if (count > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            for (int i = 0; i < initialArray.Length; i++)
            {
                long number = initialArray[i];
                if (count == 0)
                {
                    break;
                }
                if (EvenOdd(typeEvenOdd, number))
                {
                    temp += number + ", ";
                    count--;
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

        static long[] LastCount(int count, string typeEvenOdd, long[] initialArray)
        {
            if (count > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                long number = initialArray[i];
                if (count == 0)
                {
                    break;
                }
                if (EvenOdd(typeEvenOdd, number))
                {
                    temp = number + ", " + temp;
                    count--;
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

        static void MaxEvenOdd(string typeMinOrMax, long[] initialArray)
        {
            long maxValue = long.MinValue;
            int maxIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                long number = initialArray[index];
                if (EvenOdd(typeMinOrMax, number))
                {
                    if (number >= maxValue)
                    {
                        maxValue = number;
                        maxIndex = index;
                    }
                }
            }
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinEvenOdd(string typeMinOrMax, long[] initialArray)
        {
            long minValue = long.MaxValue;
            int minIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                long number = initialArray[index];
                if (EvenOdd(typeMinOrMax, number))
                {
                    if (number <= minValue)
                    {
                        minValue = number;
                        minIndex = index;
                    }
                }
            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        private static bool EvenOdd(string typeMinOrMax, long number)
        {
            if ((typeMinOrMax == "even" && number % 2 == 0) || (typeMinOrMax == "odd" && number % 2 != 0))
            {
                return true;
            }
            return false;
        }

        static long[] ExchangeArray(int exchangeIndex, long[] initialArray)
        {
            if (exchangeIndex >= initialArray.Length)
            {
                Console.WriteLine("Invalid index");
                return initialArray;
            }
            long[] newArray = new long[initialArray.Length];
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
