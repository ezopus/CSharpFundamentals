string removable = Console.ReadLine();
string input = Console.ReadLine();
while (input.Contains(removable) == true)
{
    input = input.Replace(removable, "");
}
Console.WriteLine(input);