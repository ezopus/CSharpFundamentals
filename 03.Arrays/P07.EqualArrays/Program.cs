using System;

int[] firstArray = Console
        .ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
int[] secondArray = Console
        .ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
bool isIdentical = true, isDifferent = false;
int sumFirst = 0, sumSecond = 0;
int differenceIndex = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    sumFirst += firstArray[i];
    sumSecond += secondArray[i];
    if (!isDifferent && firstArray[i] != secondArray[i])
    {
        isIdentical = false;
        isDifferent = true;
        differenceIndex = i;
    }
}
if (isIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sumFirst}");
}
else
{
    Console.WriteLine($"Arrays are not identical. Found difference at {differenceIndex} index");
}