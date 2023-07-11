using System.Text;
using System.Text.RegularExpressions;

int numberOfMessages = int.Parse(Console.ReadLine());
string regex = @"[@](?<planet>[A-Za-z]+)[^@!:->]*[:](?<population>\d+)[^@!:->]*[!](?<type>[A|D])[!][^@!:->]*[->](?<soldiers>\d+)";
StringBuilder decrypted = new StringBuilder();
List<string> attackedPlanets = new List<string>();
List<string> destroyedPlanets = new List<string>();
for (int i = 0; i < numberOfMessages; i++)
{
    string input = Console.ReadLine();
    int counter = 0;
    foreach (char c in input.ToLower())
    {
        if (c == 's' || c == 't' || c == 'a' || c == 'r')
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        foreach (char c in input)
        {
            decrypted.Append((char)(c - counter));
        }
    }
    else
    {
        decrypted.Append(input);
    }

    if (Regex.IsMatch(decrypted.ToString(), regex))
    {
        Match currentPlanet = Regex.Match(decrypted.ToString(), regex);
        if (currentPlanet.Groups["type"].Value == "A")
        {
            attackedPlanets.Add(currentPlanet.Groups["planet"].Value);
        }
        else
        {
            destroyedPlanets.Add(currentPlanet.Groups["planet"].Value);
        }
    }
    decrypted.Clear();
}

int attacks = attackedPlanets.Count;
int destroyed = destroyedPlanets.Count;

Console.WriteLine($"Attacked planets: {attacks}");
if (attacks > 0)
{
    foreach (var p in attackedPlanets.OrderBy(x => x))
    {
        Console.WriteLine($"-> {p}");
    }
}

Console.WriteLine($"Destroyed planets: {destroyed}");
if (destroyed > 0)
{
    foreach (var p in destroyedPlanets.OrderBy(x => x))
    {
        Console.WriteLine($"-> {p}");
    }
}
/*
3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR

pp$##@Coruscant:2000000000!D!->5000
@Jakku:200000!A!MMMM
@Cantonica:3000!D!->4000NM
*/