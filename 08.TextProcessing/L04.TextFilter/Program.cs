string[] filter = Console
    .ReadLine()
    .Split(", ");

string input = Console.ReadLine();
foreach (string s in filter)
{
    string replacement = new string('*', s.Length);
    input = input.Replace(s, replacement);
}

Console.WriteLine(input);
