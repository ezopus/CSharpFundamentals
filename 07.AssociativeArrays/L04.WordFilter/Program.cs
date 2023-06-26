string[] allWords = Console.ReadLine()
    .Split(" ")
    .Where(x => x.Length % 2 == 0)
    .ToArray();
foreach (string s in allWords)
{
    Console.WriteLine(s);
}