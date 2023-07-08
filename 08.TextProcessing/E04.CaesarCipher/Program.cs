using System.Text;

char[] input = Console
    .ReadLine()
    .ToCharArray();

StringBuilder sb = new StringBuilder ();
foreach (char c in input)
{
    sb.Append ((char)(c + 3));
}

Console.WriteLine(sb);