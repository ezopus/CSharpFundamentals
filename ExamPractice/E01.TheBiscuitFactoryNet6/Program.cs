
int biscuitsPerDay = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
int competingBiscuits = int.Parse(Console.ReadLine());
double totalBiscuitsPerDay = biscuitsPerDay * workers;

double totalBiscuits = Math.Floor(30 * totalBiscuitsPerDay - (10 * 0.25 * totalBiscuitsPerDay));

Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
double difference = totalBiscuits - competingBiscuits;
double percentage = Math.Abs(difference / competingBiscuits) * 100;
if (competingBiscuits - totalBiscuits > 0)
{
    Console.WriteLine($"You produce {percentage:F2} percent less biscuits.");
}
else
{
    Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
}