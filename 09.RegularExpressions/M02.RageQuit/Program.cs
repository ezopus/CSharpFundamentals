using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string stringPattern = @"[^\d]+";
string numberPattern = @"\d+";
MatchCollection strings = Regex.Matches(input, stringPattern);
MatchCollection numbers = Regex.Matches(input, numberPattern);

List<string> uniqueChars = new List<string>();
StringBuilder outputString = new StringBuilder();

for (int i = 0; i < strings.Count; i++)
{
    string repeat = "";
    for (int j = 0; j < int.Parse(numbers[i].ToString()); j++)
    {
        repeat += strings[i].ToString();
    }
    outputString.Append(repeat.ToUpper());
}

foreach (char c in outputString.ToString())
{
    if (!uniqueChars.Contains(c.ToString()))
    {
        uniqueChars.Add(c.ToString());
    }
}

Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
Console.WriteLine(outputString);


/*
aSd2&5s@1
 */
