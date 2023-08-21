string password = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Complete")
{
    string[] tokens = input.Split();
    switch (tokens[0])
    {
        case "Make":
            string command = tokens[1];
            int index = int.Parse(tokens[2]);
            password = Make(password, command, index);
            break;
        case "Insert":
            index = int.Parse(tokens[1]);
            string insertChar = tokens[2];
            password = Insert(password, index, insertChar);
            break;
        case "Replace":
            char charToReplace = char.Parse(tokens[1]);
            int value = int.Parse(tokens[2]);
            password = Replace(password, charToReplace, value);
            break;
        case "Validation":
            Validation(password);
            break;
        default:
            break;
    }
}

string Make(string password, string command, int index)
{
    char[] temp = password.ToCharArray();
    if (command == "Upper")
    {
        if (index >= 0 && index < password.Length)
        {
            string uppercase = temp[index].ToString().ToUpper();
            temp[index] = char.Parse(uppercase);
            password = string.Join("", temp);
        }
    }
    else if (command == "Lower")
    {
        if (index >= 0 && index < password.Length)
        {
            string lowercase = temp[index].ToString().ToLower();
            temp[index] = char.Parse(lowercase);
            password = string.Join("", temp);
        }
    }

    Console.WriteLine(password);
    return password;
}

string Insert(string password, int index, string insertChar)
{
    if (index >= 0 && index < password.Length)
    {
        password = password.Insert(index, insertChar);
    }

    Console.WriteLine(password);
    return password;
}

string Replace(string password, char charToReplace, int value)
{
    int sum = charToReplace + value;
    char newSymbol = (char)sum;
    password = password.Replace(charToReplace, newSymbol);
    Console.WriteLine(password);
    return password;
}

void Validation(string password)
{
    bool isLetterOrDigitOrUnderscore = true;
    bool hasLower = false;
    bool hasUpper = false;
    bool hasDigit = false;

    if (password.Length < 8)
    {
        Console.WriteLine("Password must be at least 8 characters long!");
    }
    foreach (char c in password)
    {
        if (!char.IsLetterOrDigit(c) && c != '_')
        {
            isLetterOrDigitOrUnderscore = false;
        }
        if (char.IsLower(c) && hasLower == false)
        {
            hasLower = true;
        }

        if (char.IsUpper(c) && hasUpper == false)
        {
            hasUpper = true;
        }

        if (char.IsDigit(c))
        {
            hasDigit = true;
        }
    }

    if (!isLetterOrDigitOrUnderscore)
    {
        Console.WriteLine("Password must consist only of letters, digits and _!");
    }

    if (!hasUpper)
    {
        Console.WriteLine("Password must consist at least one uppercase letter!");
    }
    if (!hasLower)
    {
        Console.WriteLine("Password must consist at least one lowercase letter!");
    }

    if (!hasDigit)
    {
        Console.WriteLine("Password must consist at least one digit!");
    }
}