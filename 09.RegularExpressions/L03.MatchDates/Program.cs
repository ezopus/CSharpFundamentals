using System.Text.RegularExpressions;

string regex = @"\b(?<day>\d{2})(.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>[\d]{4})\b";

string dates = Console.ReadLine();

MatchCollection matches = Regex.Matches(dates, regex);

foreach (Match date in matches)
{
    var day = date.Groups["day"].Value;
    var month = date.Groups["month"].Value;
    var year = date.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}