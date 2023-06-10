using System;
using System.Collections.Generic;
using System.Linq;

namespace M03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> encryptedString = Console.ReadLine().ToCharArray().ToList();
            List<int> digits = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<char> nonNumbers = new List<char>();

            SplitInitialStringToNumbersAndChars(encryptedString, digits, nonNumbers);

            CreateTakeSkipLists(digits, takeList, skipList);

            List<char> result = new List<char>();
           
            int totalSkipped = 0;
            string endResult = "";
            for (int i = 0; i < takeList.Count; i++)
            {
                if (i < takeList.Count)
                {
                    if (totalSkipped + takeList[i] >= nonNumbers.Count)
                    {
                        result = nonNumbers.GetRange(totalSkipped, nonNumbers.Count - totalSkipped);
                        endResult += string.Join(null, result);
                        break;
                    }
                    result = nonNumbers.GetRange(totalSkipped, takeList[i]);
                    endResult += string.Join(null, result);
                    totalSkipped += skipList[i] + takeList[i];
                }
            }

            Console.WriteLine(endResult);
        }

        static void CreateTakeSkipLists(List<int> digits, List<int> evenDigits, List<int> oddDigits)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenDigits.Add(digits[i]);
                }
                else
                {
                    oddDigits.Add(digits[i]);
                }
            }
        }

        static void SplitInitialStringToNumbersAndChars(List<char> encryptedString, List<int> digits, List<char> nonNumbers)
        {
            foreach (char c in encryptedString)
            {
                if (char.IsDigit(c))
                {
                    digits.Add(int.Parse(c.ToString()));
                }
                else
                {
                    nonNumbers.Add(c);
                }
            }
        }
    }
}
