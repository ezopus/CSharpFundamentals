using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "rock";
            const string Paper = "paper";
            const string Scissors = "scissors";
            string playerMove = "";
            while (playerMove != "stop")
            {
                Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors:");
                playerMove = Console.ReadLine().ToLower();
                if (playerMove == "stop") break;
                Random randomMove = new Random();
                int computerRandomMove = randomMove.Next(1, 4);
                string computerMove = "";
                switch (computerRandomMove)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                if ((playerMove == Rock && computerMove == Scissors)
                    || (playerMove == Paper && computerMove == Scissors)
                    || (playerMove == Scissors && computerMove == Paper))
                {
                    Console.WriteLine("You win.");
                }
                else if ((playerMove == Rock && computerMove == Paper)
                         || (playerMove == Paper && computerMove == Scissors)
                         || (playerMove == Scissors && computerMove == Rock))
                {
                    Console.WriteLine("You lose.");
                }
                else if ((playerMove == Rock && computerMove == Rock)
                         || (playerMove == Paper && computerMove == Paper)
                         || (playerMove == Scissors && computerMove == Scissors))
                {
                    Console.WriteLine("The game is a draw");
                }
            }
        }
    }
}
