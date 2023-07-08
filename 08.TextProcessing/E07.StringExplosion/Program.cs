using System.Text;

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();
int strength = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        sb.Append(input[i]);
        strength += input[i + 1] - '0';
    }
    else if (input[i] != '>' && strength > 0)
    {
        strength--;
        continue;
    }
    else
    {
        sb.Append(input[i]);
    }
}

Console.WriteLine(sb);