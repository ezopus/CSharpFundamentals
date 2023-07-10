using System.Text.RegularExpressions;

string regex = @"\+359(-| )[2]\1\d{3}\1\d{4}";
string numbers = Console.ReadLine();
MatchCollection matches = Regex.Matches(numbers, regex);

string[] matchedPhones = matches
    .Cast<Match>()
    .Select(x => x.Value.Trim())
    .ToArray();

Console.WriteLine(string.Join(", ", matchedPhones));