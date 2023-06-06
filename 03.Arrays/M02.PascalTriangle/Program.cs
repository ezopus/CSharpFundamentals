using System.Diagnostics.Metrics;

int input = int.Parse(Console.ReadLine());
long[] tempArray;
Console.WriteLine(1);
long[] row = { 1 };
while (input > 1)
{
    int counter = row.Length;
    long[] nextRow = new long[counter + 1];
    nextRow[0] = 1;
    nextRow[nextRow.Length - 1] = 1;
    for (int i = 1; i < row.Length; i++)
    {
        nextRow[i] = row[i] + row[i - 1];
    }
    row = new long[nextRow.Length];
    row = nextRow;
    Console.WriteLine(string.Join(' ', nextRow));
    input--;
}
//
//
//
// int input = int.Parse(Console.ReadLine());
//
// for (long line = 1; line <= input; line++)
// {
//     long C = 1;
//     for (long i = 1; i <= line; i++)
//     {
//         Console.Write(C + " ");
//         C = C * (line - i) / i;
//     }
//     Console.WriteLine();
// }
