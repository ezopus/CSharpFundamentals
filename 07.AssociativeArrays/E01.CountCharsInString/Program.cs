string[] input = Console.ReadLine()
    .Split(" ");

char[] charString = string.Join("", input).ToCharArray();

var chars = new Dictionary<char, int>();

foreach (char s in charString)
{
    if (chars.ContainsKey(s))
    {
        chars[s]++;
    }
    else
    {
        chars.Add(s, 1);
    }
}

foreach (var c in chars)
{
    Console.WriteLine($"{c.Key} -> {c.Value}");
}