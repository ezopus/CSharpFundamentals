string encrypted = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Decode")
{
    string[] tokens = input.Split("|");
    string action = tokens[0];
    switch (action)
    {
        case "Move":
            int index = int.Parse(tokens[1]);
            encrypted = MoveLetters(encrypted, index);
            break;
        case "Insert":
            index = int.Parse(tokens[1]);
            string value = tokens[2];
            encrypted = InsertValue(encrypted, index, value);
            break;
        case "ChangeAll":
            string substring = tokens[1];
            string replacement = tokens[2];
            encrypted = ChangeAll(encrypted, substring, replacement);
            break;
        default:
            break;
    }
}

Console.WriteLine($"The decrypted message is: {encrypted}");

string MoveLetters(string encrypted, int index)
{
    string remainder = encrypted.Substring(index);
    string moved = encrypted.Substring(0, index);
    return remainder + moved;
}

string InsertValue(string encrypted, int index, string value)
{
    return encrypted.Insert(index, value);
}

string ChangeAll(string encrypted, string substring, string replacement)
{
    return encrypted.Replace(substring, replacement);
}