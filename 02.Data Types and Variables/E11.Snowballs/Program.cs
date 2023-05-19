int totalSnowballs = int.Parse(Console.ReadLine());
int bestSnowballSnow = 0;
int bestSnowballTime = 0;
int bestSnowballQuality = 0;
decimal bestValue = 0;
for (int i = 0; i < totalSnowballs; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
    decimal snowballValue = (decimal)Math.Pow((snowballSnow / snowballTime), snowballQuality);
    if (snowballValue > bestValue)
    {
        bestSnowballSnow = snowballSnow;
        bestSnowballTime = snowballTime;
        bestSnowballQuality = snowballQuality;
        bestValue = snowballValue;
    }
}
Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");

