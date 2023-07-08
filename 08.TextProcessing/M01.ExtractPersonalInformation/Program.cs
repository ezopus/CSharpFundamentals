int numberOfLines = int.Parse(Console.ReadLine());
string name = "";
int age = 0;
for (int i = 0; i < numberOfLines; i++)
{
    string input = Console.ReadLine();
    int indexNameStart = input.IndexOf("@");
    int indexNameEnd = input.IndexOf("|");
    int indexAgeStart = input.IndexOf("#");
    int indexAgeEnd = input.IndexOf("*");
    name = input.Substring(indexNameStart + 1, indexNameEnd - indexNameStart - 1);
    age = int.Parse(input.Substring(indexAgeStart + 1, indexAgeEnd - indexAgeStart - 1));
    Console.WriteLine($"{name} is {age} years old.");
}