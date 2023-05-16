namespace P11.MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (p <= 10)
            {
                for (int i = p; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else Console.WriteLine($"{n} X {p} = {n * p}");
        }
    }
}