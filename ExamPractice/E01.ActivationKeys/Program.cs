string rawInput = Console.ReadLine();
string commands = "";
while ((commands = Console.ReadLine()) != "Generate")
{
    string[] command = commands.Split(">>>");
    switch (command[0])
    {
        case "Contains":
            string substring = command[1];
            Contains(rawInput, substring);
            break;
        case "Flip":
            string direction = command[1];
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);
            rawInput = Flip(rawInput, direction, startIndex, endIndex);
            break;
        case "Slice":
            startIndex = int.Parse(command[1]);
            endIndex = int.Parse(command[2]);
            rawInput = Slice(rawInput, startIndex, endIndex);
            break;
        default:
            break;
    }
}

Console.WriteLine($"Your activation key is: {rawInput}");


void Contains(string rawInput, string substring)
{
    if (rawInput.Contains(substring))
    {
        Console.WriteLine($"{rawInput} contains {substring}");
    }
    else
    {
        Console.WriteLine("Substring not found!");
    }

}

string Flip(string rawInput, string direction, int startIndex, int endIndex)
{
    int length = endIndex - startIndex;
    if (direction == "Upper")
    {
        string upper = rawInput.Substring(startIndex, length).ToUpper();
        rawInput = rawInput.Remove(startIndex, length);
        rawInput = rawInput.Insert(startIndex, upper);
    }
    else if (direction == "Lower")
    {
        string lower = rawInput.Substring(startIndex, length).ToLower();
        rawInput = rawInput.Remove(startIndex, length);
        rawInput = rawInput.Insert(startIndex, lower);
    }

    Console.WriteLine($"{rawInput}");
    return rawInput;
}

string Slice(string rawInput, int startIndex, int endIndex)
{
    rawInput = rawInput.Remove(startIndex, endIndex - startIndex);
    Console.WriteLine($"{rawInput}");
    return rawInput;
}


/*
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def
Contains>>>deF
Generate
 */