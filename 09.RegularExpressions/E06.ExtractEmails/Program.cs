using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @" \b([A-Za-z][A-Za-z0-9]+|([A-Za-z0-9])+([\.|\-|_])([A-Za-z0-9]+))\@([a-z]+[\-])*([a-z]+[\.])*([a-z]+[\.][a-z]{2,})\b";

MatchCollection emails = Regex.Matches(input, pattern);

foreach (Match email in emails)
{
    Console.WriteLine(email);
}

