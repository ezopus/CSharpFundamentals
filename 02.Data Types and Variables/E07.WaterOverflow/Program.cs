int waterTank = 0;
int numberOfPours = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfPours; i++)
{
    int singlePour = int.Parse(Console.ReadLine());
    if (waterTank + singlePour > 255)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    else
    {
        waterTank += singlePour;   
    }
    
}
Console.WriteLine(waterTank);