int number = int.Parse(Console.ReadLine());
int currentSum = 0;
int currentNumber = 0;
bool isSpecialNum = false;
for (int i = 1; i <= number; i++)
{
    currentNumber = i;
    while (i > 0)
    {
        currentSum += i % 10;
        i = i / 10;
    }
    isSpecialNum = (currentSum == 5) || (currentSum == 7) || (currentSum == 11);
    Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
    currentSum = 0;
    i = currentNumber;
}