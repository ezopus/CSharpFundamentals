string input = Console.ReadLine();
string letters = "";
string numbers = "";
string otherChars = "";
foreach (char c in input)
{
    if (char.IsLetter(c) == true)
    {
        letters += c;
    }
    else if (char.IsDigit(c) == true)
    {
        numbers += c;
    }
    else
    {
        otherChars += c;
    }
}

Console.WriteLine(numbers);
Console.WriteLine(letters);
Console.WriteLine(otherChars);