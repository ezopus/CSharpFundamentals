namespace P09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            int counter = 1;
            while (counter <= n)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    counter++;
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}