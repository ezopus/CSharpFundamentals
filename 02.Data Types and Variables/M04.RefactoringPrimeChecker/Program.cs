int inputNumber = int.Parse(Console.ReadLine());
for (int counter = 2; counter <= inputNumber; counter++)
{
    bool isPrime = true;
    for (int divider = 2; divider < counter; divider++)
    {
        if (counter % divider == 0)
        {
            isPrime = false;
            break;
        }
    }
    Console.WriteLine($"{counter} -> {isPrime.ToString().ToLower()}");
}