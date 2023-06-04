using System;

namespace E07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixN = int.Parse(Console.ReadLine());
            PrintNxNMatrix(matrixN);
        }

        private static void PrintNxNMatrix(int matrixN)
        {
            for (int i = 0; i < matrixN; i++)
            {
                for (int j = 0; j < matrixN; j++)
                {
                    Console.Write(matrixN + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
