string input = Console.ReadLine();
while (input != "END")
{
    bool dataBool;
    int dataInt;
    double dataDouble;
    char dataChar;
    if (int.TryParse(input, out dataInt) == true)
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out dataDouble) == true)
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out dataChar) == true)
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out dataBool) == true)
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
    input = Console.ReadLine();
}