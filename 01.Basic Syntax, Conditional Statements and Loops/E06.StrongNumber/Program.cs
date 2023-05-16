int number = int.Parse(Console.ReadLine());
int totalSum = 0;
int workingNumber = number;
while (workingNumber > 0)
{
    int individualSum = 1;
    for (int i = 1; i <= workingNumber % 10; i++)
    {
        individualSum *= i;
    }
    totalSum += individualSum;
    workingNumber = workingNumber / 10;
}
if (totalSum == number)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}