using System.Text;

string[] input = Console.ReadLine().Split();
StringBuilder output  = new StringBuilder();
foreach (string s in input)
{
    for (int i = 0; i < s.Length; i++)
    {
        output.Append(s);
    }
}
Console.WriteLine(output);