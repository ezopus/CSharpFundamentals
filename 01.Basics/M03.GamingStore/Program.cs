double currentBalance = double.Parse(Console.ReadLine());
string input = "";
double gamePrice = 0;
double totalSpent = 0;

while ((input = Console.ReadLine()) != "Game Time")
{
    switch (input)
    {
        case "OutFall 4":
            gamePrice = 39.99;
            break;
        case "CS: OG":
            gamePrice = 15.99;
            break;
        case "Zplinter Zell":
            gamePrice = 19.99;
            break;
        case "Honored 2":
            gamePrice = 59.99;
            break;
        case "RoverWatch":
            gamePrice = 29.99;
            break;
        case "RoverWatch Origins Edition":
            gamePrice = 39.99;
            break;
        default:
            Console.WriteLine("Not Found");
            continue;
    }
    if (currentBalance - gamePrice >= 0)
    {
        currentBalance -= gamePrice;
        totalSpent += gamePrice;
        Console.WriteLine($"Bought {input}");
        if (currentBalance == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else if (currentBalance - gamePrice < 0)
    {
        Console.WriteLine("Too Expensive");
        continue;
    }
}
if (currentBalance > 0) Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");