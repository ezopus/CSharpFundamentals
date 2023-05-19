ulong startingYield = ulong.Parse(Console.ReadLine());
int totalDays = 0;
ulong totalExtractedAmount = 0;
while (startingYield >= 100)
{
    totalExtractedAmount += startingYield;
    totalDays++;
    startingYield -= 10;
    if (totalExtractedAmount >= 26)
    {
        totalExtractedAmount -= 26;
    }
}
if (totalExtractedAmount >= 26)
{
    totalExtractedAmount -= 26;
}
Console.WriteLine(totalDays);
Console.WriteLine(totalExtractedAmount);
