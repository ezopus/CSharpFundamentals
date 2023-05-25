int[] numberArray = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
while (numberArray.Length > 1)
{
    int[] condensed = new int[numberArray.Length - 1];
    for (int i = 0; i < numberArray.Length - 1; i++)
    {
        condensed[i] = numberArray[i] + numberArray[i + 1];
    }
    numberArray = new int[condensed.Length];
    foreach (int number in condensed)
    {
        numberArray = condensed;
    }
}
Console.WriteLine(string.Join("", numberArray));