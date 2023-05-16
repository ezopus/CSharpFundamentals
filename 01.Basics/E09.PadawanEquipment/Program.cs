double amountOfMoney = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice =  double.Parse(Console.ReadLine());
double robePrice =  double.Parse(Console.ReadLine());
double beltPrice =  double.Parse(Console.ReadLine());

double totalCost = Math.Ceiling(students * 1.1) * lightsaberPrice + (robePrice + beltPrice) * students;
if (students >= 6)
{
    totalCost -= students / 6 * beltPrice;
}

if (amountOfMoney >= totalCost)
{
    Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {totalCost - amountOfMoney:f2}lv more.");
}
