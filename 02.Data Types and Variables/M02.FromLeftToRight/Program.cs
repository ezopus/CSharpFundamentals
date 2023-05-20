int numberOfLines = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfLines; i++)
{
    string bothNumbers = Console.ReadLine();
    string firstNumberString = string.Empty;
    string secondNumberString = string.Empty;
    bool spacePoint = false;
    for (int j = 0; j < bothNumbers.Length; j++)
    {
        if (bothNumbers[j] != ' ')
        {
            if (spacePoint == false)
            {
                firstNumberString += bothNumbers[j];
            }
            else
            {
                secondNumberString += bothNumbers[j];
            }
        }
        else
        {
            spacePoint = true;
        }
    }
    long firstNumber = long.Parse(firstNumberString);
    long secondNumber = long.Parse(secondNumberString);
    long sumNumberDigits = 0;
    if (firstNumber >= secondNumber)
    {
        firstNumber = Math.Abs(firstNumber);
        while (firstNumber > 0)
        {
            sumNumberDigits += firstNumber % 10;
            firstNumber /= 10;
        }
    }
    else
    {
        secondNumber = Math.Abs(secondNumber);
        while (secondNumber > 0)
        {
            sumNumberDigits += secondNumber % 10;
            secondNumber /= 10;
        }
    }
    Console.WriteLine(sumNumberDigits);
}