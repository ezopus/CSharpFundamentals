using System.Text.RegularExpressions;

string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
string winningPattern = @"(?<symbols>\${6,}|\#{6,}|\^{6,}|@{6,})";

foreach (string ticket in input)
{
    if (ticket.Length == 20)
    {
        string leftHalf = ticket.Substring(0, 10);
        string rightHalf = ticket.Substring(10, 10);
        if (Regex.IsMatch(leftHalf, winningPattern) && Regex.IsMatch(rightHalf, winningPattern))
        {
            leftHalf = Regex.Match(leftHalf, winningPattern).Groups["symbols"].Value;
            rightHalf = Regex.Match(rightHalf, winningPattern).Groups["symbols"].Value;
            if (leftHalf == rightHalf || (leftHalf.Contains(rightHalf) || rightHalf.Contains(leftHalf)))
            {
                if (leftHalf.Length == 10 && rightHalf.Length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {leftHalf.Length}{leftHalf[0]} Jackpot!");
                }
                else
                {
                    int symbolCount = Math.Min(leftHalf.Length, rightHalf.Length);
                    Console.WriteLine($"ticket \"{ticket}\" - {symbolCount}{leftHalf[0]}");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
        else
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
        }
    }
    else
    {
        Console.WriteLine("invalid ticket");
    }
}


/*
$$$$$$$$$$$$$$$$$$$$, aabb, th@@@@@@eemo@@@@@@ey, Sixx$$$$$$Sev$$$$$$$, Sixx$$$$$$Si$$$$$$xx
*/