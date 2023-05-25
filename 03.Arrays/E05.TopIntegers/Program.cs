int[] arrayAsString = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
bool isGreaterToTheRight = false;
for (int i = 0; i < arrayAsString.Length; i++)
{
    for (int j = i+1;  j < arrayAsString.Length; j++)
    {
        if (arrayAsString[i] > arrayAsString[j])
        {
            isGreaterToTheRight = true;
        }
        else
        {
            isGreaterToTheRight = false;
            break;
        }
    }
    if (isGreaterToTheRight)
    {
        Console.Write(arrayAsString[i] + " ");
    }    
}
if (!isGreaterToTheRight) { Console.WriteLine(arrayAsString[arrayAsString.Length - 1]); }