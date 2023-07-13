using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(\#|\@)(?<pairFirst>[A-Za-z]{3,})\1\1(?<pairSecond>[A-Za-z]{3,})\1";

MatchCollection matches = Regex.Matches(input, pattern);
List<string> mirrorWords = new List<string>();

foreach (Match match in matches)
{
    string firstWord = match.Groups["pairFirst"].Value;
    char[] secondWord = match.Groups["pairSecond"].Value.ToCharArray();
    Array.Reverse(secondWord);
    string reversedSecondWord = string.Join("", secondWord);
    if (firstWord == reversedSecondWord)
    {
        Array.Reverse(secondWord);
        mirrorWords.Add($"{firstWord} <=> {string.Join("", secondWord)}");
    }
}

if (matches.Count > 0)
{
    Console.WriteLine($"{matches.Count} word pairs found!");

}
else
{
    Console.WriteLine("No word pairs found!");
}

if (mirrorWords.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", mirrorWords));
}
else
{
    Console.WriteLine("No mirror words!");
}
