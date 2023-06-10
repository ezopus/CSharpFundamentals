using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstPlayerHand = firstDeck[0];
                int secondPlayerHand = secondDeck[0];
                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);
                
                if (firstPlayerHand > secondPlayerHand)
                {
                    firstDeck.Add(secondPlayerHand);
                    firstDeck.Add(firstPlayerHand);
                }
                else if (firstPlayerHand < secondPlayerHand)
                {
                    secondDeck.Add(firstPlayerHand);
                    secondDeck.Add(secondPlayerHand);
                }
            }

            if (firstDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {DeckSum(secondDeck)}");
            }
            else if (secondDeck.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {DeckSum(firstDeck)}");
            }
        }

        static int DeckSum(List<int> deck)
        {
            int sum = 0;
            foreach (int number in deck)
            {
                sum += number;
            }

            return sum;
        }
    }
}
