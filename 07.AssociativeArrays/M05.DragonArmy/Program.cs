var dragonList = new Dictionary<string, List<Dragon>>();
int numberOfDragons = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfDragons; i++)
{
    string[] input = Console.ReadLine().Split();
    string type = input[0];
    string name = input[1];
    double damage = 0;
    if (double.TryParse(input[2], out damage))
        damage = double.Parse(input[2]);
    else damage = 45;
    double health = 0;
    if (double.TryParse(input[3], out health))
        health = double.Parse(input[3]);
    else health = 250;
    double armor = 0;
    if (double.TryParse(input[4], out armor))
        armor = double.Parse(input[4]);
    else armor = 10;
    Dragon current = new Dragon(name, damage, health, armor);
    if (dragonList.ContainsKey(type))
    {
        Dragon existing = dragonList[type].Find(x => x.Name == name);
        if (existing != null)
        {
            existing.Health = health;
            existing.Armor = armor;
            existing.Damage = damage;
        }
        else
        {
            dragonList[type].Add(current);
        }
    }
    else
    {
        dragonList.Add(type, new List<Dragon>());
        dragonList[type].Add(current);
    }
}

foreach (var dragon in dragonList)
{
    double averageDamage = dragon.Value.Sum(x => x.Damage) / dragon.Value.Count;
    double averageArmor = dragon.Value.Sum(x => x.Armor) / dragon.Value.Count;
    double averageHealth = dragon.Value.Sum(x => x.Health) / dragon.Value.Count;
    Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
    foreach (var one in dragon.Value.OrderBy(x => x.Name))
    {
        Console.WriteLine($"-{one.Name} -> damage: {one.Damage}, health: {one.Health}, armor: {one.Armor}");
    }
}

public class Dragon
{
    public Dragon(string name, double damage, double health, double armor)
    {
        Name = name;
        Damage = damage;
        Health = health;
        Armor = armor;
    }
    public string Name { get; set; }
    public double Damage { get; set; }
    public double Health { get; set; }
    public double Armor { get; set; }
}