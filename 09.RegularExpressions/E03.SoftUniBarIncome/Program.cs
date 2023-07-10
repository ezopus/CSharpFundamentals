using System.Text.RegularExpressions;

string regex = @"[%](?<name>[A-Z][a-z]+)[%].*[<](?<item>\w+)[>].*[|](?<count>\d+)[|].*?(?<price>\d+\.\d+|\d+)[$]";
List<Match>  matches = new List<Match>();

string input = "";
while ((input = Console.ReadLine()) != "end of shift")
{
    if (Regex.IsMatch(input, regex))
    {
        Match item = Regex.Match(input, regex);
        matches.Add(item);
    }
}
double totalIncome = 0;
foreach (Match item in matches)
{
    double price = double.Parse(item.Groups["price"].Value);
    double count = double.Parse(item.Groups["count"].Value);
    Console.WriteLine($"{item.Groups["name"].Value}: {item.Groups["item"].Value} - {price*count:f2}");
    totalIncome += price * count;
}

Console.WriteLine($"Total income: {totalIncome:f2}");