using System.Text;

string[] morse = Console
    .ReadLine()
    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

StringBuilder output = new StringBuilder();
foreach (string s in morse)
{
    string[] currentWord = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string word in currentWord)
    {
        if (word.Length < 2)
        {
            if (word.Contains('.')) output.Append('E');
            else output.Append('T');
        }
        else if (word.Length < 3)
        {
            if (word.All(c => c == '.')) output.Append('I');
            else if (word.Any(c => c == '.'))
            {
                if (word.IndexOf('.') == 0) output.Append('A');
                else output.Append('N');
            }
            else output.Append('M');
        }
        else if (word.Length < 4)
        {
            if (word.All(c => c == '.')) output.Append('S');
            else if (word.Any(c => c == '.'))
            {
                if (word.IndexOf('.') == 0 && word.LastIndexOf('.') == 1) output.Append('U');
                else if (word.IndexOf('.') == 0 && word.LastIndexOf('.') == 2) output.Append('R');
                else if (word.IndexOf('.') == 1 && word.LastIndexOf('.') == 2) output.Append('D');
                else if (word.IndexOf('.') == 0 && word.Count(c => c == '-') == 2) output.Append('W');
                else if (word.IndexOf('.') == 1 && word.Count(c => c == '-') == 2) output.Append('K');
                else output.Append('G');
            }
            else output.Append('O');
        }
        else if (word.Length < 5)
        {
            if (word.All(c => c == '.')) output.Append('H');
            else if (word.Any(c => c == '.'))
            {
                if (word.Count(c => c == '.') == 1)
                {
                    if (word.IndexOf('.') == 0) output.Append('J');
                    if (word.IndexOf('.') == 1) output.Append('Y');
                    if (word.IndexOf('.') == 2) output.Append('Q');
                }
                else if (word.Count(c => c == '-') == 1)
                {
                    if (word.IndexOf('-') == 0) output.Append('B');
                    if (word.IndexOf('-') == 1) output.Append('L');
                    if (word.IndexOf('-') == 2) output.Append('F');
                    if (word.IndexOf('-') == 3) output.Append('V');
                }
                else if (word.IndexOf('.') == 0 && word.LastIndexOf('.') == 3) output.Append('P');
                else if (word.IndexOf('.') == 1 && word.LastIndexOf('.') == 3) output.Append('C');
                else if (word.IndexOf('.') == 1 && word.LastIndexOf('.') == 2) output.Append('X');
                else if (word.IndexOf('.') == 2 && word.LastIndexOf('.') == 3) output.Append('Z');
            }
        }
    }
    output.Append(" ");
}

Console.WriteLine(output);
