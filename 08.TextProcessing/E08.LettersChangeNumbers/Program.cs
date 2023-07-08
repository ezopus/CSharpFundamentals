using System.Text;

string[] input = Console
    .ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
double currentSum = 0;
double totalSum = 0;
double middleNumber;
char firstLetter;
char secondLetter;
foreach (string token in input)
{
    firstLetter = token[0];
    secondLetter = token[token.Length - 1];
    middleNumber = double.Parse(token.Substring(1, token.Length - 2));

    if (char.IsUpper(firstLetter))
    {
        currentSum = middleNumber / (firstLetter - 64);
    }
    else if (char.IsLower(firstLetter))
    {
        currentSum = middleNumber * (firstLetter - 96);
    }

    if (char.IsUpper(secondLetter))
    {
        currentSum -= (secondLetter - 64);
    }
    else if (char.IsLower(secondLetter))
    {
        currentSum += (secondLetter - 96);
    }

    totalSum += currentSum;
}

Console.WriteLine($"{totalSum:f2}");