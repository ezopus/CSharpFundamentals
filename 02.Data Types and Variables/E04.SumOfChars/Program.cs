int interval = int.Parse(Console.ReadLine());
int sumOfChars = 0;
for (int i = 0; i < interval; i++)
{
    char singleChar = char.Parse(Console.ReadLine());
    sumOfChars += (int)singleChar;
}
Console.WriteLine($"The sum equals: {sumOfChars}");