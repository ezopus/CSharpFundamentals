int input = int.Parse(Console.ReadLine());
for (int i = 0; i < input; i++)
{
    int[] arrayOne = new int[i+1];
    for (int j = 0; j < i; j++)
    {
        arrayOne[i] = i + j;
    }
    Console.Write(string.Join(" ", arrayOne));
    Console.WriteLine();
}