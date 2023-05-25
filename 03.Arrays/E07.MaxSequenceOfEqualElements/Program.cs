int[] array = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sequenceCounter = 0;
int longestSequence = 0;
int longestSequenceStart = 0;
int longestSequenceValue = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            sequenceCounter++;
        }
        else
        {
            break;
        }
    }
    if (sequenceCounter > longestSequence)
    {
        longestSequence = sequenceCounter;
        longestSequenceStart = i;
        longestSequenceValue = array[i];
    }
        sequenceCounter = 0;
}
while (longestSequence >= 0)
{
    Console.Write(longestSequenceValue + " ");
    longestSequence--;

}