string[] firstString = Console
                .ReadLine()
                .Split()
                .ToArray();
string[] secondString = Console
                .ReadLine()
                .Split()
                .ToArray();
for (int i = 0; i < secondString.Length; i++)
{
    for (int j = 0; j < firstString.Length; j++)
    {
        if (secondString[i] == firstString[j])
        {
            Console.Write(secondString[i] + " ");
        }
    }
}