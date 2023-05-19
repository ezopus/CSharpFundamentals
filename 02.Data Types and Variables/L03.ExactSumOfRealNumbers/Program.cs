int numbers = int.Parse(Console.ReadLine());
decimal totalSum = 0;
for (int i = 0; i < numbers; i++)
{
    totalSum += decimal.Parse(Console.ReadLine());
}
Console.WriteLine(totalSum);