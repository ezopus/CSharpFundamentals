using System;

namespace E01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialEnergy = double.Parse(Console.ReadLine());
            string input = "";
            int wonBattles = 0;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                double singleBattle = double.Parse(input);
                if (initialEnergy < singleBattle)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    break;
                }
                initialEnergy -= singleBattle;
                wonBattles++;

                if (wonBattles % 3 == 0)
                {
                    initialEnergy += wonBattles;
                }

            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
            }


        }
    }
}
