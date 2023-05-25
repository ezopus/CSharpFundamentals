using System;

int sampleLength = int.Parse(Console.ReadLine());
string input = "";
int bestSequenceSum = 0;
int sampleCounter = 0;
int[] bestSampleArray = new int[sampleLength];
int bestSampleNumber = 0;
while ((input = Console.ReadLine()) != "Clone them!")
{
    sampleCounter++;
    int[] sequenceArray = input
            .Split('!')
            .Select(int.Parse)
            .ToArray();

    int sequenceCounter = 1;
    int longestSequence = 1;
    int longestSequenceStart = 0;
    //int longestSequenceValue = 0;
    for (int i = 0; i < sequenceArray.Length - 1; i++)
    {
        for (int j = i + 1; j < sequenceArray.Length; j++)
        {
            if (sequenceArray[i] == sequenceArray[j])
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
            //longestSequenceValue = sequenceArray[i];
            int currentSum = 0;
            for (int k = 0; k < sequenceArray.Length; k++)
            {
                currentSum += sequenceArray[k];
            }
            if (currentSum < bestSequenceSum)
            {
                bestSequenceSum = currentSum;
                bestSampleNumber = i;
                foreach (int number in sequenceArray)
                {
                    bestSampleArray = sequenceArray;
                }
            }
        }
        sequenceCounter = 0;
    }
}
Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSequenceSum}");
Console.WriteLine(string.Join("!", bestSampleArray));
