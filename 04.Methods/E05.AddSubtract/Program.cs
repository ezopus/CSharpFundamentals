using System;

namespace E05.AddSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            Console.WriteLine(ResultMinusThirdInteger(SumFirstTwo(firstInteger, secondInteger), thirdInteger));
            
        }

        private static int ResultMinusThirdInteger(int sumFirstTwo, int thirdInteger)
        {
            return sumFirstTwo - thirdInteger;
        }

        private static int SumFirstTwo(int firstInteger, int secondInteger)
        {
            return firstInteger + secondInteger;
        }
    }
}
