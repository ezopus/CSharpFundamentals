using System;
using System.Collections.Generic;
using System.Linq;

namespace M05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumset = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> initialQuality = drumset.ToList();
            string input = "";
            int counterRemovedDrums = 0;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);
                for (int i = 0; i < drumset.Count; i++)
                {
                    drumset[i] -= hitPower;
                    if (drumset[i] <= 0)
                    {
                        int replacementDrum = initialQuality[i + counterRemovedDrums] * 3;
                        if (savings - replacementDrum >= 0)
                        {
                            savings -= initialQuality[i + counterRemovedDrums] * 3;
                            drumset[i] = initialQuality[i + counterRemovedDrums];
                        }
                        else
                        {
                            drumset.RemoveAt(i);
                            i--;
                            if (counterRemovedDrums < i)
                            {
                                counterRemovedDrums++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', drumset));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
