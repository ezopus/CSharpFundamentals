double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double highest = 0;
double lowest = 0;
double middle = 0;
if (a > b && a > c)
{
    highest = a;
    if (b > c) { middle = b; lowest = c; }
    else { middle = c; lowest = b; }
}
else if (b > a && b > c)
{
    highest = b;
    if (a > c) { middle = a; lowest = c; }
    else { middle = c; lowest = a; }
}
else if (c > a && c > b)
{
    highest = c;
    if (a > b) { middle = a; lowest = b; }
    else { middle = b; lowest = a; }
}
Console.WriteLine(highest);
Console.WriteLine(middle);
Console.WriteLine(lowest);