﻿int[] numberArray = Console
        .ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
int evenSum = 0;
for (int i = 0; i < numberArray.Length; i++)
{
    if (numberArray[i] % 2 == 0)
    {
        evenSum += numberArray[i];
    }
}
Console.WriteLine(evenSum);