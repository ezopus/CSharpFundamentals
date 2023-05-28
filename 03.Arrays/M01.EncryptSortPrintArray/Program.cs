int inputCount = int.Parse(Console.ReadLine());
int[] allInputs = new int[inputCount];
for (int i = 0; i < inputCount; i++)
{
    char[] totalChars = Console.ReadLine().ToCharArray();
    int sumOfChars = 0;
    for (int j = 0; j < totalChars.Length; j++)
    {
        char oneChar = totalChars[j];
        switch (oneChar)
        {
            case 'A':
            case 'O':
            case 'E':
            case 'I':
            case 'U':
            case 'a':
            case 'o':
            case 'e':
            case 'i':
            case 'u':
                sumOfChars += (int)oneChar * totalChars.Length;
                break;
            default:
                sumOfChars += (int)oneChar / totalChars.Length;
                break;
        }
    }
    allInputs[i] = sumOfChars;
}
Array.Sort(allInputs);
foreach (int number in allInputs)
{
    Console.WriteLine(number);
}