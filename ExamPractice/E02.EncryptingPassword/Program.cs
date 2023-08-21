using System.Text.RegularExpressions;

int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    string password = Console.ReadLine();
    string pattern = @"(?<Start>[^>]+)(\>)(?<Digits>\d{3})\|(?<Lowercase>[a-z]{3})\|(?<Uppercase>[A-Z]{3})\|(?<Symbols>[^><]{3})(\<)(?<End>[\S]+)";

    Match match = Regex.Match(password, pattern);

    if (Regex.IsMatch(password, pattern))
    {
        if (match.Groups["Start"].Value == match.Groups["End"].Value)
        {
            string digits = match.Groups["Digits"].Value;
            string lowercase = match.Groups["Lowercase"].Value;
            string uppercase = match.Groups["Uppercase"].Value;
            string symbols = match.Groups["Symbols"].Value;
            Console.WriteLine($"Password: {digits + lowercase + uppercase + symbols}");
        }
        else
        {
            Console.WriteLine("Try another password!");
        }
    }
    else
    {
        Console.WriteLine("Try another password!");
    }
}
