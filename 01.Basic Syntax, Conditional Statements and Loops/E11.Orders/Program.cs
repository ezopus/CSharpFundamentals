int numberOfOrders = int.Parse(Console.ReadLine());
double totalPrice = 0;
while (numberOfOrders > 0)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double individualOrder = ((days * capsulesCount) * pricePerCapsule);
    
    totalPrice += individualOrder;
    
    Console.WriteLine($"The price for the coffee is: ${individualOrder:f2}");

    numberOfOrders--;
}
Console.WriteLine($"Total: ${totalPrice:f2}");
