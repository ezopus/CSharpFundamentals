using System;
using System.Collections.Generic;
using System.Linq;

namespace M01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string message = Console.ReadLine();
            string result = "";

            for (int i = 0; i < inputList.Count; i++)
            {
                int counter = DigitSumEachElement(inputList, i) % message.Length;
                result += message[counter];
                List<char> removeOneChar = new List<char>();
                foreach (char c in message)
                {
                    removeOneChar.Add(c);
                }
                removeOneChar.RemoveAt(i);
                message = string.Join(null, removeOneChar);
            }

            Console.WriteLine(result);
        }

        private static void RemoveSingleIndex(List<int> inputList, int counter)
        {

        }

        private static int DigitSumEachElement(List<int> inputList, int index)
        {
            int digits = inputList[index];
            int sum = 0;
            while (digits > 0)
            {
                sum += digits % 10;
                digits /= 10;
            }
            return sum;
        }
    }
}
