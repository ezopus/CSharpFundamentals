using System;

namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lower = 1;
            int upper = 100;
            Random numberToGuess = new Random();
            int computerNumber = numberToGuess.Next(lower, upper);

            while (true)
            {
                Console.Write($"Guess a number ({lower}-{upper}):");
                int playerGuess = int.Parse(Console.ReadLine());
                if (playerGuess == computerNumber)
                {
                    Console.WriteLine("You guessed it!");
                    upper += 100;
                    computerNumber = numberToGuess.Next(lower, upper);
                    //break;
                }
                else if (playerGuess > computerNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (playerGuess < computerNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
