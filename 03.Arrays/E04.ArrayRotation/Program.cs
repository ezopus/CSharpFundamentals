int[] originalArray = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
int rotationCount = int.Parse(Console.ReadLine());
while (rotationCount > 0)
{
    int temp = originalArray[0];
    for (int i = 0; i < originalArray.Length - 1; i++)
    {
        originalArray[i] = originalArray[i + 1];      
    }
    originalArray[originalArray.Length - 1] = temp;
    rotationCount--;
}
Console.WriteLine(string.Join(" ", originalArray));