
List<string> friendList = Console.ReadLine()
    .Split(", ")
    .ToList();

string input = "";
int totalBlacklisted = 0;
int totalLost = 0;
while ((input = Console.ReadLine()) != "Report")
{
    string[] commands = input.Split();
    switch (commands[0])
    {
        case "Blacklist":
            string blacklisted = commands[1];
            BlacklistName(friendList, blacklisted, ref totalBlacklisted);
            break;
        case "Error":
            int index = int.Parse(commands[1]);
            ListError(friendList, index, ref totalLost);
            break;
        case "Change":
            index = int.Parse(commands[1]);
            string newName = commands[2];
            ChangeList(friendList, index, newName);
            break;
        default:
            break;
    }

}
Console.WriteLine($"Blacklisted names: {totalBlacklisted}");
Console.WriteLine($"Lost names: {totalLost}");
Console.WriteLine(string.Join(" ", friendList));

static List<string> BlacklistName(List<string> friendList, string blacklisted, ref int totalBlacklisted)
{
    if (friendList.Contains(blacklisted))
    {
        int blacklistedIndex = friendList.IndexOf(blacklisted);
        Console.WriteLine($"{blacklisted} was blacklisted.");
        friendList[blacklistedIndex] = "Blacklisted";
        totalBlacklisted++;
    }
    else
    {
        Console.WriteLine($"{blacklisted} was not found.");
    }
    return friendList;
}

static List<string> ListError(List<string> friendList, int index, ref int totalLost)
{
    if (index >= 0 && index < friendList.Count
                   && friendList[index] != "Lost"
                   && friendList[index] != "Blacklisted")
    {
        Console.WriteLine($"{friendList[index]} was lost due to an error.");
        friendList[index] = "Lost";
        totalLost++;
    }
    return friendList;
}

static List<string> ChangeList(List<string> friendList, int index, string newName)
{
    if (index >= 0 && index < friendList.Count)
    {
        string currentName = friendList[index];
        Console.WriteLine($"{currentName} changed his username to {newName}.");
        friendList[index] = newName;
    }
    return friendList;
}