int numberOfWords = int.Parse(Console.ReadLine());
var synonyms = new Dictionary<string, List<string>>();
for (int i = 0; i < numberOfWords; i++)
{
    string originalWord = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (!synonyms.ContainsKey(originalWord))
    {
        synonyms.Add(originalWord, new List<string>());
    }
    synonyms[originalWord].Add(synonym);
}

foreach (var synonym in synonyms)
{
    Console.Write($"{synonym.Key} - ");
    Console.WriteLine(string.Join(", ", synonym.Value));
}