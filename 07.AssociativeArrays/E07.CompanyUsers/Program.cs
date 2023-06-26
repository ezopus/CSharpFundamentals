var companies = new Dictionary<string, List<string>>();
string input = "";
while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(" -> ");
    string company = tokens[0];
    string employeeID = tokens[1];
    if (!companies.ContainsKey(company))
    {
        companies.Add(company, new List<string>());
    }

    if (!companies[company].Contains(employeeID))
    {
        companies[company].Add(employeeID);
    }
    
}

foreach (var c in companies)
{
    Console.WriteLine($"{c.Key}");
    foreach (string s in c.Value)
    {
        Console.WriteLine($"-- {s}");
    }
}