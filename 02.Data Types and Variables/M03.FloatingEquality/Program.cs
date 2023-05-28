double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());
var difference = 0.000001;

var result = Math.Abs(numberA - numberB);

if (result < difference)
{
    Console.WriteLine("True");
}
else Console.WriteLine("False");
    
