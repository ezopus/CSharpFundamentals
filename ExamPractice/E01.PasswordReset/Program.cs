string password = Console.ReadLine();
string input = "";
while ((input = Console.ReadLine()) != "Done")
{
    string[] tokens = input.Split();
    string command = tokens[0];
    switch (command)
    {
        case "TakeOdd":
            password = TakeOdd(password);
            break;
        case "Cut":
            int index = int.Parse(tokens[1]);
            int length = int.Parse(tokens[2]);
            password = CutString(password, index, length);
            break;
        case "Substitute":
            string substringToken = tokens[1];
            string substitutionToken = tokens[2];
            password = Substitute(password, substringToken, substitutionToken);
            break;
        default:
            break;
    }
}

Console.WriteLine($"Your password is: {password}");

string TakeOdd(string password)
{
    string odd = "";
    for (int i = 0; i < password.Length; i++)
    {
        if (i % 2 != 0)
        {
            odd += password[i];
        }
    }
    Console.WriteLine(odd);
    return odd;
}

string CutString(string password, int index, int length)
{
    string stringToRemove = password.Substring(index, length);
    int indexToRemove = password.IndexOf(stringToRemove);
    password = password.Remove(indexToRemove, stringToRemove.Length);
    Console.WriteLine(password);
    return password;
}
string Substitute(string password, string substringToken, string substitutionToken)
{
    if (password.Contains(substringToken))
    {
        while (password.Contains(substringToken) == true)
        {
            password = password.Replace(substringToken, substitutionToken);
        }

        Console.WriteLine(password);
    }
    else
    {
        Console.WriteLine("Nothing to replace!");
    }
    return password;
}

/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr 
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done
 */