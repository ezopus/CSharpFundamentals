using System.Text.RegularExpressions;

string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";

string input = Console.ReadLine();

MatchCollection destinations = Regex.Matches(input, pattern);

int travelPoints = 0;
if (destinations.Count > 0)
{
    travelPoints = destinations.Sum(x => x.Groups["destination"].Value.Length);
}

Console.WriteLine($"Destinations: {string.Join(", ", destinations.Select(x => x.Groups["destination"].Value).ToArray())}"); 
Console.WriteLine($"Travel Points: {travelPoints}");