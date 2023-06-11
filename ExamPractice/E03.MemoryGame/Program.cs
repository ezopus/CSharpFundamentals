using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> memoryString = Console.ReadLine()
                .Split(' ')
                .ToList();
            string input = "";
            int totalMoves = 1;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] playerTurn = input.Split(" ").Select(int.Parse).ToArray();
                
                int firstMove = playerTurn[0];
                int secondMove = playerTurn[1];

                if (CheckPlayerTurnValidity(firstMove, secondMove, memoryString, ref totalMoves))
                {
                    continue;
                }

                if (memoryString[firstMove] == memoryString[secondMove])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {memoryString[firstMove]}!");
                    memoryString.RemoveAt(firstMove);
                    memoryString.RemoveAt(Math.Max(0, secondMove - 1));
                    totalMoves++;
                    if (IsMemoryStringEmpty(memoryString, totalMoves))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                    totalMoves++;
                }
            }

            if (memoryString.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', memoryString));
            }
        }

        static bool IsMemoryStringEmpty(List<string> memoryString, int totalMoves)
        {
            if (memoryString.Count > 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine($"You have won in {totalMoves - 1} turns!");
                return true;
            }
        }
        
        static bool CheckPlayerTurnValidity(int firstMove, int secondMove, List<string> memoryString, ref int totalMoves)
        {
            if (firstMove == secondMove
                || firstMove < 0
                || firstMove >= memoryString.Count
                || secondMove < 0
                || secondMove >= memoryString.Count)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                string[] addPair = { $"-{totalMoves}a", $"-{totalMoves}a" };
                memoryString.InsertRange(memoryString.Count / 2, addPair);
                totalMoves++;
                return true;
            }

            return false;
        }
    }
}

