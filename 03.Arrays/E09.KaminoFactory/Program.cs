using System;
int sampleLength = int.Parse(Console.ReadLine());
string input = "";
int sampleCounter = 0;
int[] bestSampleArray = new int[sampleLength];
int bestSequenceSum = 0;
int bestSampleNumber = 0;
int bestStartingIndex = 0;
int bestSequence = int.MinValue;
while ((input = Console.ReadLine()) != "Clone them!")
{
    sampleCounter++;
    int[] sequenceArray = input.Split('!',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int sequenceCounter = 0;
    int currentBestSequenceCounter = 0;
    int sequenceStart = 0;
    int currentBestStartingIndex = 0;
    int currentSum = 0;
    for (int i = 0; i < sequenceArray.Length; i++)
    {
        if (sequenceArray[i] == 1)
        {
            if (sequenceCounter == 0)
            {
                sequenceStart = i;
            }
            currentSum++;
            sequenceCounter++;
        }
        if (sequenceArray[i] == 0 || i == sequenceArray.Length - 1)
        {
            if (currentBestSequenceCounter < sequenceCounter)
            {
                currentBestStartingIndex = sequenceStart;
                currentBestSequenceCounter = sequenceCounter;
            }
            sequenceCounter = 0;
        }
    }
    if (currentBestSequenceCounter > bestSequence
        || (currentBestSequenceCounter == bestSequence && currentBestStartingIndex < bestStartingIndex)
        || (currentBestSequenceCounter == bestSequence && currentBestStartingIndex == bestStartingIndex && currentSum > bestSequenceSum)
       )
    {
        bestSequence = currentBestSequenceCounter;
        bestSampleNumber = sampleCounter;
        bestSequenceSum = currentSum;
        bestStartingIndex = currentBestStartingIndex; ;
        bestSampleArray = sequenceArray;
    }
}
Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSequenceSum}.");
Console.WriteLine(string.Join(" ", bestSampleArray));