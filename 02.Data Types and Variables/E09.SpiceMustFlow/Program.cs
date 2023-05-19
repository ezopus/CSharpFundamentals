long startingYield = long.Parse(Console.ReadLine());
int totalDays = 0;
long totalExtractedAmount = 0;
while (startingYield >= 100)
{
    totalExtractedAmount += startingYield - 26;
    totalDays++;
    startingYield -= 10;
}
if (totalExtractedAmount >= 26)
{
    totalExtractedAmount -= 26;
}
Console.WriteLine(totalDays);
Console.WriteLine(totalExtractedAmount);
