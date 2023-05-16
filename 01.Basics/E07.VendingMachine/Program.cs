string input = "";
double totalSum = 0;

while ((input = Console.ReadLine()) != "Start")
{
    double individualCoin = double.Parse(input);
    if (individualCoin == 0.1 || individualCoin == 0.2 || individualCoin == 0.5 ||
        individualCoin == 1 || individualCoin == 2)
    {
        totalSum += individualCoin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {individualCoin}");
    }
}
input = Console.ReadLine();
while (totalSum >= 0)
{
    bool isProductValid = true;
    double pricePerItem = 0;
    if (input == "End")
    {
        break;
    }
    if (totalSum > 0)
    {
        switch (input)
        {
            case "Nuts":
                pricePerItem = 2;
                break;
            case "Water":
                pricePerItem = 0.7;
                break;
            case "Crisps":
                pricePerItem = 1.5;
                break;
            case "Soda":
                pricePerItem = 0.8;
                break;
            case "Coke":
                pricePerItem = 1;
                break;
            default:
                Console.WriteLine("Invalid product");
                isProductValid = false;
                break;
        }
    }
    else
    {
        break;
    }
    if (isProductValid)
    {
        if (totalSum - pricePerItem >= 0)
        {
            totalSum -= pricePerItem;
            Console.WriteLine($"Purchased {input.ToLower()}");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    input = Console.ReadLine();
}
Console.WriteLine($"Change: {totalSum:f2}");
