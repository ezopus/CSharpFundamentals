int numberOfPlants = int.Parse(Console.ReadLine());
Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
for (int i = 0; i < numberOfPlants; i++)
{
    string[] currentPlant = Console.ReadLine().Split("<->");
    string plantName = currentPlant[0];
    double rarity = double.Parse(currentPlant[1]);
    Plant plant = new Plant(rarity);
    if (plants.ContainsKey(plantName))
    {
        plants[plantName].Rarity = rarity;
    }
    else
    {
        plants.Add(plantName, plant);
    }
}

string command;
while ((command = Console.ReadLine()) != "Exhibition")
{
    string[] tokens = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
    string action = tokens[0];
    string plantName = tokens[1];
    if (plants.ContainsKey(plantName))
    {
        switch (action)
        {
            case "Rate":
                double rating = double.Parse(tokens[2]);
                plants[plantName].Rating.Add(rating);
                break;
            case "Update":
                double rarity = double.Parse(tokens[2]);
                plants[plantName].Rarity = rarity;
                break;
            case "Reset":
                plants[plantName].Rating.Clear();
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("error");
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (var plant in plants)
{
    double averageRating = 0;
    if (plant.Value.Rating.Count > 0)
    {
        averageRating = plant.Value.Rating.Average();
    }
    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {averageRating:f2}");
}


class Plant
{
    public Plant(double rarity)
    {
        Rarity = rarity;
        Rating = new List<double>();
    }

    public double Rarity { get; set; }
    public List<double> Rating { get; set; }
}

/*
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition
 */