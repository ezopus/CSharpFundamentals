string input = Console.ReadLine();
string reversedInput = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    reversedInput += input[i];
}
Console.WriteLine(reversedInput);