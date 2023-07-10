string input = "";
Dictionary<string, CityResources> cities = new Dictionary<string, CityResources>();
while ((input = Console.ReadLine()) != "Sail")
{
    string[] tokens = input.Split("||");
    string cityName = tokens[0];
    int population = int.Parse(tokens[1]);
    int gold = int.Parse(tokens[2]);
    if (cities.ContainsKey(cityName))
    {
        cities[cityName].Population += population;
        cities[cityName].Gold += gold;
    }
    else
    {
        CityResources cityResources = new CityResources(population, gold);
        cities.Add(cityName, cityResources);
    }
}

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split("=>");
    string command = tokens[0];
    string cityName = tokens[1];
    switch (command)
    {
        case "Plunder":
            int population = int.Parse(tokens[2]);
            int gold = int.Parse(tokens[3]);
            Plunder(cityName, population, gold, ref cities);
            break;
        case "Prosper":
            gold = int.Parse(tokens[2]);
            Prosper(cityName, gold, ref cities);
            break;
        default:
            break;
    }
}

if (cities.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
    foreach (var c in cities)
    {
        Console.WriteLine($"{c.Key} -> Population: {c.Value.Population} citizens, Gold: {c.Value.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}

void Plunder(string cityName, int population, int gold, ref Dictionary<string, CityResources> cities)
{
    if (cities.ContainsKey(cityName))
    {
        if (cities[cityName].Population > population && cities[cityName].Gold > gold)
        {
            cities[cityName].Population -= population;
            cities[cityName].Gold -= gold;
            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
        }
        else
        {
            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
            Console.WriteLine($"{cityName} has been wiped off the map!");
            cities.Remove(cityName);
        }
    }
}
void Prosper(string cityName, int gold, ref Dictionary<string, CityResources> cities)
{
    if (gold <= 0)
    {
        Console.WriteLine($"Gold added cannot be a negative number!");
    }
    else
    {
        cities[cityName].Gold += gold;
        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
    }
}
class CityResources
{
    public CityResources(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }
    public int Population { get; set; }
    public int Gold { get; set; }

}

/*
Nassau||95000||1000
San Juan||930000||1250
Campeche||270000||690
Port Royal||320000||1000
Port Royal||100000||2000
Sail
Prosper=>Port Royal=>-200
Plunder=>Nassau=>94000=>750
Plunder=>Nassau=>1000=>150
Plunder=>Campeche=>150000=>690
End
 */