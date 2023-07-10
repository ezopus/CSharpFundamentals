string travelString = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Travel")
{
    string[] tokens = input.Split(":");
    string action = tokens[0];
    switch (action)
    {
        case "Add Stop":
            int index = int.Parse(tokens[1]);
            string toInsert = tokens[2];
            travelString = AddStop(travelString, index, toInsert);
            break;
        case "Remove Stop":
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);
            travelString = RemoveStop(travelString, startIndex, endIndex);
            break;
        case "Switch":
            string oldString = tokens[1];
            string newString = tokens[2];
            travelString = ReplaceString(travelString, oldString, newString);
            break;
        default:
            break;
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {travelString}");

string AddStop(string travelString, int index, string toInsert)
{
    if (travelString.Length > index)
    {
        travelString = travelString.Insert(index, toInsert);
    }
    Console.WriteLine(travelString);
    return travelString;
}

string RemoveStop(string travelString, int startIndex, int endIndex)
{
    if (startIndex >= 0 && startIndex <= endIndex && travelString.Length > endIndex)
    {
        travelString = travelString.Remove(startIndex, endIndex - startIndex + 1);
    }
    Console.WriteLine(travelString);
    return travelString;
}

string ReplaceString(string travelString, string oldString, string newString)
{
    if (travelString.Contains(oldString))
    {
        travelString = travelString.Replace(oldString, newString);
    }
    Console.WriteLine(travelString);
    return travelString;
}