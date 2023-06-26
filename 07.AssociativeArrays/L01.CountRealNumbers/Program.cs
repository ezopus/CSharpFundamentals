double[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();

var counts = new SortedDictionary<double, int>();

foreach (double number in numbers)
{
    if (counts.ContainsKey(number))
    {
        counts[number]++;
    }
    else
    {
        counts[number] = 1;
    }
}

foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}