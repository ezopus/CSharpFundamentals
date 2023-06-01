using System;

namespace L04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleLength = int.Parse(Console.ReadLine());

            TriangleTop(triangleLength);
            TriangleBottom(triangleLength - 1);
        }

        private static void TriangleTop(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                RowGenerator(i);
                Console.WriteLine();
            }
        }

        private static void TriangleBottom(int end)
        {
            for (int i = end; i >= 1; i--)
            {
                RowGenerator(i);
                Console.WriteLine();
            }
        }

        private static void RowGenerator(int end)
        {
            for (int j = 1; j <= end; j++)
            {
                Console.Write(j + " ");
            }
        }
    }
}
