string[] input = Console
    .ReadLine()
    .Split();
string first = input[0];
string second = input[1];
int maxLength = Math.Max(first.Length, second.Length);
int totalSum = 0;
for (int i = 0; i < maxLength; i++)
{
    if (i < first.Length && i < second.Length)
    {
        totalSum += first[i] * second[i];
    }
    else if (i < first.Length)
    {
        totalSum += first[i];
    }
    else
    {
        totalSum += second[i];
    }
}

Console.WriteLine(totalSum);