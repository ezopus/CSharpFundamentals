using System;
using System.Collections.Generic;
using System.Linq;

namespace E09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sumRemovedElements = 0;

            while (distances.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                if (indexToRemove < 0)
                {
                    int removedElement = distances[0];
                    sumRemovedElements += removedElement;
                    distances[0] = distances[distances.Count - 1];
                    distances = IncreaseDecrease(distances, removedElement);
                }
                else if (indexToRemove > distances.Count - 1)
                {
                    int removedElement = distances[distances.Count - 1];
                    sumRemovedElements += removedElement;
                    distances[distances.Count - 1] = distances[0];
                    distances = IncreaseDecrease(distances, removedElement);
                }
                else
                {
                    int removedElement = distances[indexToRemove];
                    sumRemovedElements += removedElement;
                    distances.RemoveAt(indexToRemove);
                    distances = IncreaseDecrease(distances, removedElement);
                }

            }

            Console.WriteLine(sumRemovedElements);
        }

        private static List<int> IncreaseDecrease(List<int> distances, int removedElement)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedElement)
                {
                    distances[i] += removedElement;
                }
                else
                {
                    distances[i] -= removedElement;
                }
            }
            return distances;
        }
    }
}
