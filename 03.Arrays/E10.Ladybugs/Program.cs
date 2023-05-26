long[] field = new long[long.Parse(Console.ReadLine())];
long[] initialIndexes = Console
    .ReadLine()
    .Split()
    .Select(long.Parse)
    .ToArray();
foreach (var index in initialIndexes)
{
    if (index < field.Length && index >= 0)
    {
        field[index] = 1;
    }
}
var input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] move = input.Split();
    var ladybugStartingIndex = long.Parse(move[0]);
    var direction = move[1];
    var flyLength = long.Parse(move[2]);
    if (ladybugStartingIndex >= field.Length || ladybugStartingIndex < 0 || field[ladybugStartingIndex] == 0)
    {
        continue;
    }

    field[ladybugStartingIndex] = 0;

    if (direction == "right")
    {
        var landingPosition = ladybugStartingIndex + flyLength;
        if (landingPosition > field.Length - 1 || landingPosition < 0)
        {
            continue;
        }
        if (field[landingPosition] == 1)
        {
            while (field[landingPosition] == 1)
            {
                landingPosition += flyLength;
                if (landingPosition > field.Length - 1)
                {
                    break;
                }
            }
        }

        if (landingPosition <= field.Length - 1)
        {
            field[landingPosition] = 1;
        }
        
    }
    else if (direction == "left")
    {
        var landingPosition = ladybugStartingIndex - flyLength;
        if (landingPosition > field.Length - 1 || landingPosition < 0)
        {
            continue;
        }
        if (field[landingPosition] == 1)
        {
            while (field[landingPosition] == 1)
            {
                landingPosition -= flyLength;
                if (landingPosition < 0)
                {
                    break;
                }
            }
        }

        if (landingPosition >= 0)
        {
            field[landingPosition] = 1;
        }
    }

}

Console.WriteLine(string.Join(' ', field));
