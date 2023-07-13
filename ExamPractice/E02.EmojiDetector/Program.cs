using System.Text.RegularExpressions;

string pattern = @"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);

int coolnessThreshold = 1;
foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        coolnessThreshold *= (c - '0');
    }
}

Console.WriteLine($"Cool threshold: {coolnessThreshold}");

Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
foreach (Match match in matches)
{
    string value = match.Groups["emoji"].Value;
    int sum = 0;
    foreach (char c in value)
    {
        sum += c;
    }

    if (sum > coolnessThreshold)
    {
        Console.WriteLine($"{match}");
    }
}
