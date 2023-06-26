string[] input = Console.ReadLine()
    .Split(" ")
    .ToArray();

var elements = new Dictionary<string, int>();

foreach (string s in input)
{
    string lowerCaseWord = s.ToLower();
    if (elements.ContainsKey(lowerCaseWord))
    {
        elements[lowerCaseWord]++;
    }
    else
    {
        elements.Add(lowerCaseWord, 1);
    }
}

foreach (var c in elements)
{
    if (c.Value % 2 != 0)
    {
        Console.Write(c.Key + " ");
    }
}