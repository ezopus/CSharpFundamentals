int numberOfHeroes = int.Parse(Console.ReadLine());
Dictionary<string, Stats> heroes = new Dictionary<string, Stats>();

for (int i = 0; i < numberOfHeroes; i++)
{
    string[] tokens = Console
        .ReadLine()
        .Split();
    string heroName = tokens[0];
    double health = double.Parse(tokens[1]);
    double mana = double.Parse(tokens[2]);
    Stats current = new Stats(health, mana);
    heroes.Add(heroName, current);
}

string input = "";

while ((input = Console.ReadLine()) != "End")
{
    string[] actions = input.Split(" - ");
    string action = actions[0];
    string heroName = actions[1];
    switch (action)
    {
        case "CastSpell":
            double mpCost = double.Parse(actions[2]);
            string spell = actions[3];
            CastSpell(heroName, mpCost, spell);
            break;
        case "TakeDamage":
            double damage = double.Parse(actions[2]);
            string attacker = actions[3];
            TakeDamage(heroName, damage, attacker);
            break;
        case "Recharge":
            double manaRecharge = double.Parse(actions[2]);
            ManaRecharge(heroName, manaRecharge);
            break;
        case "Heal":
            double healthRecharge = double.Parse(actions[2]);
            Heal(heroName, healthRecharge);
            break;
        default:
            break;
    }
}

foreach (var hero in heroes)
{
    Console.WriteLine($"{hero.Key}");
    Console.WriteLine($"  HP: {hero.Value.Health}");
    Console.WriteLine($"  MP: {hero.Value.Mana}");
}
void CastSpell(string heroName, double mpCost, string spell)
{
    if (heroes[heroName].Mana >= mpCost)
    {
        heroes[heroName].Mana -= mpCost;
        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName].Mana} MP!");
    }
    else
    {
        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
    }
}
void TakeDamage(string heroName, double damage, string attacker)
{
    if (heroes[heroName].Health > damage)
    {
        heroes[heroName].Health -= damage;
        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].Health} HP left!");
    }
    else
    {
        heroes.Remove(heroName);
        Console.WriteLine($"{heroName} has been killed by {attacker}!");
    }
}
void ManaRecharge(string heroName, double manaRecharge)
{
    if (heroes[heroName].Mana + manaRecharge > 200)
    {
        manaRecharge = 200 - heroes[heroName].Mana;
        heroes[heroName].Mana = 200;
    }
    else
    {
        heroes[heroName].Mana += manaRecharge;
    }

    Console.WriteLine($"{heroName} recharged for {manaRecharge} MP!");
}
void Heal(string heroName, double healthRecharge)
{
    if (heroes[heroName].Health + healthRecharge > 100)
    {
        healthRecharge = 100 - heroes[heroName].Health;
        heroes[heroName].Health = 100;
    }
    else
    {
        heroes[heroName].Health += healthRecharge;
    }

    Console.WriteLine($"{heroName} healed for {healthRecharge} HP!");
}
class Stats
{
    public Stats(double health, double mana)
    {
        Health = health;
        Mana = mana;
    }
    public double Health { get; set; }
    public double Mana { get; set; }
}