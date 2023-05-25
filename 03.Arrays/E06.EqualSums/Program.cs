int[] array = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
bool hasEqualElement = false;
int equalElementIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;
    for (int j = i - 1; j >= 0; j--)
    {
        leftSum += array[j];
    }
    for (int j = i + 1; j < array.Length; j++)
    {
        rightSum += array[j];
    }
    if (leftSum == rightSum)
    {
        hasEqualElement = true;
        equalElementIndex = i;
        break;
    }
}
if (hasEqualElement)
{
    Console.WriteLine(equalElementIndex);
}
else
{
    Console.WriteLine("no");
}