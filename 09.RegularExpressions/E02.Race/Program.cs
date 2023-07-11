using System.Text.RegularExpressions;

List<string> participants = Console.ReadLine().Split(", ").ToList();
Dictionary<string, int> contestResults = new Dictionary<string, int>();
string regexName = @"(?<name>[^A-Za-z]+)";
string regexDistance = @"\D+";

string input = "";
while ((input = Console.ReadLine()) != "end of race")
{
    if (Regex.IsMatch(input, regexName))
    {
        string currentContestant = Regex.Replace(input, regexName, "");
        if (participants.Contains((currentContestant)))
        {
            string currentResult = Regex.Replace(input, regexDistance, "");
            int distance = currentResult.Select(x => (int)x - '0').Sum();

            if (contestResults.ContainsKey(currentContestant))
            {
                contestResults[currentContestant] += distance;
            }
            else
            {
                contestResults.Add(currentContestant, distance);
            }
        }
    }
}

string[] winners = contestResults.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();

Console.WriteLine($"1st place: {winners[0]}");
Console.WriteLine($"2nd place: {winners[1]}");
Console.WriteLine($"3rd place: {winners[2]}");