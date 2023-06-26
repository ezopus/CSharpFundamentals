string input = "";
var resources = new Dictionary<string, double>();
while ((input = Console.ReadLine()) != "stop")
{
    double amount = 0;
    amount = double.Parse(Console.ReadLine());
    string helper = input;
    if (resources.ContainsKey(input))
    {
        resources[input] += amount;
    }
    else
    {
        resources.Add(input, amount);
    }
}
foreach (var element in resources)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}