int numbers = int.Parse(Console.ReadLine());
int[] numberArray = new int[numbers];
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = int.Parse(Console.ReadLine());
}
for (int i = numberArray.Length - 1; i >= 0; i--)
{
    Console.Write(numberArray[i] + " ");
}