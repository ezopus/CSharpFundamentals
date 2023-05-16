string input = Console.ReadLine();
string login = Console.ReadLine();
//string password = "";
int loginCounter = 0;
string password = string.Concat(input.Reverse());

/*for (int i = input.Length - 1; i >= 0; i--)
{
    password += input[i];
}*/

while (loginCounter < 3)
{
    if (login != password)
    {
        Console.WriteLine("Incorrect password. Try again.");
        loginCounter++;   
    }
    else
    {
        Console.WriteLine($"User {input} logged in.");
        break;
    }
    login = Console.ReadLine();
}
if (loginCounter == 3) Console.WriteLine($"User {input} blocked!");