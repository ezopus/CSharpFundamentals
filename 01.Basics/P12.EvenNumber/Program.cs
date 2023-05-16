namespace P12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    n = int.Parse(Console.ReadLine());
                }
                
            }
            
        }
    }
}