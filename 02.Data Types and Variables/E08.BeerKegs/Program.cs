int numberOfKegs = int.Parse(Console.ReadLine());
string biggestKegName = "";
double biggestKegVolume = double.MinValue;
for (int i = 0; i < numberOfKegs; i++)
{
    string modelOfKeg = Console.ReadLine();
    float radiusOfKeg = float.Parse(Console.ReadLine());
    int heightOfKeg = int.Parse(Console.ReadLine());
    double kegVolume = Math.PI * Math.Pow (radiusOfKeg, 2) * heightOfKeg;
    if (kegVolume > biggestKegVolume)
    {
        biggestKegVolume = kegVolume;
        biggestKegName = modelOfKeg;
    }
}
Console.WriteLine(biggestKegName);