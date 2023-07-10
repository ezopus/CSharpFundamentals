using System.Text.RegularExpressions;

string regex = @">>(?<name>[A-Z]+|[A-Z][a-z]+)<<(?<price>\d+.\d+|\d+)!(?<amount>\d+)\b";
string input = "";
List<Match> matches = new List<Match>();
while ((input = Console.ReadLine()) != "Purchase")
{
    if (Regex.IsMatch(input, regex))
    {
        Match furniture = Regex.Match(input, regex);
        matches.Add(furniture);
    }
}

double totalPrice = matches.Sum(x => double.Parse(x.Groups["price"].Value) * double.Parse(x.Groups["amount"].Value));

Console.WriteLine("Bought furniture:");
foreach (Match furn in matches)
{
    Console.WriteLine($"{furn.Groups["name"].Value}");
}

Console.WriteLine($"Total money spend: {totalPrice:f2}");