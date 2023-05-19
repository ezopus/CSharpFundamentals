char character = char.Parse(Console.ReadLine());
if (character >= 65 && character <= 91)
{
    Console.WriteLine("upper-case");
}
else if (character >= 97 && character <= 123)
{
    Console.WriteLine("lower-case");
}