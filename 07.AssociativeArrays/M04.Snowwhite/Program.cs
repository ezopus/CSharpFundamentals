string input = "";
var dwarvesList = new List<Dwarf>();
while ((input = Console.ReadLine()) != "Once upon a time")
{
    string[] tokens = input.Split(" <:> ");
    string name = tokens[0];
    string hatColor = tokens[1];
    int physics = int.Parse(tokens[2]);
    Dwarf current = new Dwarf(name, hatColor, physics);
    Dwarf existingDwarf = dwarvesList.Find(x => x.Name == name && x.HatColor == hatColor);
    if (existingDwarf != null)
    {
        if (existingDwarf.Physics < physics)
        {
            existingDwarf.Physics = physics;
        }
    }
    else
    {
        dwarvesList.Add(current);
    }
}

foreach (var dwarf in dwarvesList.OrderByDescending(x => x.Physics).ThenByDescending(x => dwarvesList.Count(y => y.HatColor == x.HatColor)))
{
    Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
}

public class Dwarf
{
    public Dwarf(string name, string hatColor, int physics)
    {
        Name = name;
        HatColor = hatColor;
        Physics = physics;
    }
    public string Name { get; set; }
    public string HatColor { get; set; }
    public int Physics { get; set; }
}
