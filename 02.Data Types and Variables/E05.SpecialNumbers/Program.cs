int number = int.Parse(Console.ReadLine());
int sumOfDigits = 0;
int counter = 0;
bool isSpecial = false;
for (int i = 1; i <= number; i++)
{
    int currentNumber = i;
    while (currentNumber > 0)
    {
        sumOfDigits += currentNumber % 10;
        currentNumber /= 10;
    }
    if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
    {
        isSpecial = true;
    }
    else
    {
        isSpecial = false;
    }
    Console.WriteLine($"{i} -> {isSpecial}");
    sumOfDigits = 0;
}