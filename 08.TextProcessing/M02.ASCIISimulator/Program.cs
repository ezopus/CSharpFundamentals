char startLimit = char.Parse(Console.ReadLine());
char endLimit = char.Parse(Console.ReadLine());
string input = Console.ReadLine();
int totalSum = 0;
foreach (char c in input)
{
    if (c > startLimit && c < endLimit)
    {
        totalSum += c;
    }
}

Console.WriteLine(totalSum);