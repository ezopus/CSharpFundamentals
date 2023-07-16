using System.Text.RegularExpressions;

string[] demons = Console.ReadLine().Split(new [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
List<Demon> demonList = new List<Demon>();

foreach (string demon in demons)
{
    Demon currentDemon = new Demon();
    currentDemon.DemonName = demon;
    currentDemon.Health = Health(demon);
    currentDemon.Damage = Damage(demon);
    demonList.Add(currentDemon);
}

foreach (var demon in demonList.OrderBy(x => x.DemonName))
{
    Console.WriteLine($"{demon.DemonName} - {demon.Health} health, {demon.Damage:f2} damage");
}

int Health(string demonName)
{
    int health = 0;
    string namePattern = @"[^0-9\+\-\/\*\.]";
    MatchCollection name = Regex.Matches(demonName, namePattern);

    foreach (Match match in name)
    {
        health += match.Value[0];
    }
    return health;
}

decimal Damage(string demonName)
{
    decimal damage = 0m;
    string damagePattern = @"(?:(?:\+|\-)?(?:\d+\.\d+|\d+))";
    MatchCollection damageNumbers = Regex.Matches(demonName, damagePattern);
    foreach (var damageNumber in damageNumbers)
    {
        damage += decimal.Parse(damageNumber.ToString());
    }

    string modifyPattern = @"[\/\*]";
    MatchCollection modifiers = Regex.Matches(demonName, modifyPattern);
    foreach (var modifier in modifiers)
    {
        if (modifier.ToString() == "*")
        {
            damage *= 2;
        }
        else
        {
            damage /= 2;
        }
    }

    return damage;
}

class Demon
{
    public string DemonName { get; set; }
    public int Health { get; set; }
    public decimal Damage { get; set; }

}