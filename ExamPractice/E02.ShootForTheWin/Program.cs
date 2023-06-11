using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = "";
            int targetSum = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int oneShotIndex = int.Parse(input);

                if (oneShotIndex >= 0 && oneShotIndex < targets.Count)
                {
                    int shotValue = targets[oneShotIndex];
                    targets = TargetShoot(targets, oneShotIndex, ref targetSum);
                    targets = IncreaseDecreaseTargets(targets, oneShotIndex, shotValue);
                }
            }

            Console.WriteLine($"Shot targets: {targetSum} -> " + string.Join(' ', targets));
            
        }

        private static List<int> IncreaseDecreaseTargets(List<int> targets, int oneShotIndex, int shotValue)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] != -1)
                {
                    if (targets[i] <= shotValue)
                    {
                        targets[i] += shotValue;
                    }
                    else
                    {
                        targets[i] -= shotValue;
                    }
                }
            }
            return targets;
        }

        static List<int> TargetShoot(List<int> targets, int oneShotIndex, ref int targetSum)
        {
            if (targets[oneShotIndex] != -1)
            {
                targetSum++;
                targets[oneShotIndex] = -1;
            }
            return targets;
        }
    }
}
