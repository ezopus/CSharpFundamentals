var animals = new Dictionary<string, Animal>();
string input;
while ((input = Console.ReadLine()) != "EndDay")
{
    string[] tokens = input.Split();
    switch (tokens[0])
    {
        case "Add:":
            string[] currentAnimalToken = tokens[1].Split('-');
            string animalName = currentAnimalToken[0];
            double neededFoodQuantity = double.Parse(currentAnimalToken[1]);
            string areaName = currentAnimalToken[2];
            var currentAnimal = new Animal(animalName, neededFoodQuantity, areaName);
            if (animals.ContainsKey(animalName))
            {
                animals[animalName].DailyFoodLimit += neededFoodQuantity;
            }
            else
            {
                animals.Add(animalName, currentAnimal);
            }
            break;

        case "Feed:":
            currentAnimalToken = tokens[1].Split('-');
            animalName = currentAnimalToken[0];
            double food = double.Parse(currentAnimalToken[1]);
            if (animals.ContainsKey(animalName))
            {
                if (animals[animalName].DailyFoodLimit - food > 0)
                {
                    animals[animalName].DailyFoodLimit -= food;
                }
                else
                {
                    animals.Remove(animalName);
                    Console.WriteLine($"{animalName} was successfully fed");
                }
            }
            break;
    }
}

Console.WriteLine("Animals:");
foreach (var a in animals)
{
    Console.WriteLine($"{a.Key} -> {a.Value.DailyFoodLimit}g");
}

var hungryAreas = new Dictionary<string, int>();

foreach (var a in animals)
{
    if (hungryAreas.ContainsKey(a.Value.AreaName))
    {
        hungryAreas[a.Value.AreaName]++;
    }
    else
    {
        hungryAreas.Add(a.Value.AreaName, 1);
    }
}

Console.WriteLine("Areas with hungry animals:");
foreach (var a in hungryAreas)
{
    Console.WriteLine($"{a.Key}: {a.Value}");
}
class Animal
{
    public Animal(string name, double neededFoodQuantity, string areaName)
    {
        Name = name;
        DailyFoodLimit = neededFoodQuantity;
        AreaName = areaName;
    }
    public string Name { get; set; }
    public string AreaName { get; set; }
    public double DailyFoodLimit { get; set; }
}