string[] regularArray = Console
    .ReadLine()
    .Split()
    .ToArray();
for (int i = 0; i < regularArray.Length / 2; i++)
{
    string exchange = regularArray[i];
    regularArray[i] = regularArray[regularArray.Length - 1 - i];
    regularArray[regularArray.Length - 1 - i] = exchange;
}
Console.WriteLine(string.Join(" ", regularArray));