int numberOfCommands = int.Parse(Console.ReadLine());
var users = new Dictionary<string, string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    string action = input[0];
    string name = input[1];
    if (action == "register")
    {
        string plate = input[2];
        if (users.ContainsKey(name))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plate}");
        }
        else
        {
            users.Add(name, plate);
            Console.WriteLine($"{name} registered {plate} successfully");
        }
    }
    else if (action == "unregister")
    {
        if (users.ContainsKey(name))
        {
            users.Remove(name);
            Console.WriteLine($"{name} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}

foreach (var u in users)
{
    Console.WriteLine($"{u.Key} => {u.Value}");
}