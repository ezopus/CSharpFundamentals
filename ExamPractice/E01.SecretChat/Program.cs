string encrypted = Console.ReadLine();
string input = "";
while ((input = Console.ReadLine()) != "Reveal")
{
    string[] commands = input.Split(":|:");
    switch (commands[0])
    {
        case "ChangeAll":
            string toBeChanged = commands[1];
            string replacement = commands[2];
            encrypted = ChangeAll(encrypted, toBeChanged, replacement);
            break;
        case "Reverse":
            string reversable = commands[1];
            encrypted = Reverse(encrypted, reversable);
            break;
        case "InsertSpace":
            int spaceIndex = int.Parse(commands[1]);
            encrypted = encrypted.Insert(spaceIndex, " ");
            Console.WriteLine(encrypted);
            break;
        default:
            break;
    }
}

Console.WriteLine($"You have a new text message: {encrypted}");

string Reverse(string encrypted, string reversable)
{
    if (encrypted.Contains(reversable))
    {
        int reverseIndex = encrypted.IndexOf(reversable);
        encrypted = encrypted.Remove(reverseIndex, reversable.Length);
        char[] reversedCharArray = reversable.ToCharArray();
        Array.Reverse(reversedCharArray);
        string reversed = new string(reversedCharArray);
        encrypted += string.Join("", reversed);
        Console.WriteLine(encrypted);
    }
    else
    {
        Console.WriteLine("error");
    }
    return encrypted;
}

string ChangeAll(string encrypted, string toBeChanged, string replacement)
{
    if (encrypted.Contains(toBeChanged))
    {
        encrypted = encrypted.Replace(toBeChanged, replacement);
    }
    Console.WriteLine(encrypted);
    return encrypted;
}

/*
heVVodar!gniV
ChangeAll:|:V:|:l
Reverse:|:!gnil
InsertSpace:|:5
Reveal
 */
