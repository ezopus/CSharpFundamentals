using System;

namespace E01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeRate = int.Parse(Console.ReadLine());
            int secondEmployeeRate = int.Parse(Console.ReadLine());
            int thirdEmployeeRate = int.Parse(Console.ReadLine());
            int totalStudents = int.Parse(Console.ReadLine());

            int totalTime = 0;
            int totalRate = firstEmployeeRate + secondEmployeeRate + thirdEmployeeRate;
            int hourCounter = 1;

            while (totalStudents > 0)
            {
                if (hourCounter % 4 != 0)
                {
                    totalStudents -= totalRate;
                }
                totalTime++;
                hourCounter++;
            }
            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}
