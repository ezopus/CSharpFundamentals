// See https://aka.ms/new-console-template for more information
int age = int.Parse(Console.ReadLine());
if (age >= 0 && age <= 2)
{
    Console.WriteLine("baby");
}
else if (age <= 13)
{
    Console.WriteLine("child");
}
else if (age <= 19)
{
    Console.WriteLine("teenager");
}
else if (age <= 65)
{
    Console.WriteLine("adult");
}
else if (age >= 66)
{
    Console.WriteLine("elder");
}
else Console.WriteLine("error");
