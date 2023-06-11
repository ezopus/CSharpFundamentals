using System;

namespace E01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int mostLectures = 0;
            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double currentBonus = (double)attendances / (double)lectures * (5 + bonus);
                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    mostLectures = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {mostLectures} lectures.");
        }
    }
}
