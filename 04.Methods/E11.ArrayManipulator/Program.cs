using System;
using System.Linq;
using System.Reflection;

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

        static int[] FirstCount(int count, string typeEvenOdd, int[] initialArray)
        {
            if (count > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            for (int i = 0; i < initialArray.Length; i++)
            {
                int number = initialArray[i];
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

        static int[] LastCount(int count, string typeEvenOdd, int[] initialArray)
        {
            if (count > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
                return initialArray;
            }

            string temp = "";
            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                int number = initialArray[i];
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

        static void MaxEvenOdd(string typeMinOrMax, int[] initialArray)
        {
            int maxValue = int.MinValue;
            int maxIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                int number = initialArray[index];
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
        static void MinEvenOdd(string typeMinOrMax, int[] initialArray)
        {
            int minValue = int.MaxValue;
            int minIndex = -1;
            for (int index = 0; index < initialArray.Length; index++)
            {
                int number = initialArray[index];
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
        private static bool EvenOdd(string typeMinOrMax, int number)
        {
            if ((typeMinOrMax == "even" && number % 2 == 0) || (typeMinOrMax == "odd" && number % 2 != 0))
            {
                return true;
            }
            return false;
        }

        static int[] ExchangeArray(int exchangeIndex, int[] initialArray)
        {
            if (exchangeIndex >= initialArray.Length || exchangeIndex < 0)
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
