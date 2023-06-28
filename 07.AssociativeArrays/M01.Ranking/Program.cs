var contests = new Dictionary<string, string>();
string input = "";
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] tokens = input.Split(":");
    string contestName = tokens[0];
    string password = tokens[1];
    contests.Add(contestName, password);
}

var users = new Dictionary<string, List<ContestResults>>();
while ((input = Console.ReadLine()) != "end of submissions")
{
    string[] tokens = input.Split("=>");
    string contestName = tokens[0];
    string password = tokens[1];
    string username = tokens[2];
    double points = double.Parse(tokens[3]);
    if (contests.ContainsKey(contestName))    //check if user contest exists in legit contests
    {
        if (password == contests[contestName])   //check if user password matches existing chosen contest password
        {
            ContestResults currentContestResult = new ContestResults(contestName, points);
            if (!users.ContainsKey(username))    //if user participates for first time in chosen contest, add username, contest name and result
            {
                users.Add(username, new List<ContestResults>());
                users[username].Add(currentContestResult);
            }
            else   //if user already participated in contest and score needs updating
            {
                ContestResults existingResults = users[username].Find(x => x.Contest == contestName);   //try and get contest from dictionary, where user has previously participated in
                if (existingResults != null)   //if previous contest exists
                {
                    if (existingResults.Points < points)  //check if score is lower and update if yes
                    {
                        existingResults.Points = points;
                    }
                }
                else users[username].Add(currentContestResult);   //add first user score to username for current contest
            }
        }
    }
}
double bestPoints = 0;
string bestCandidate = "";
foreach (var u in users)
{
    if (u.Value.Sum(x => x.Points) > bestPoints)
    {
        bestPoints = u.Value.Sum(x => x.Points);
        bestCandidate = u.Key;
    }
}
Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
Console.WriteLine("Ranking:");
foreach (var user in users.OrderBy(x => x.Key))
{
    Console.WriteLine(user.Key);
    foreach (var contest in user.Value.OrderByDescending(x => x.Points))
    {
        Console.WriteLine($"#  {contest.Contest} -> {contest.Points}");
    }
}
class ContestResults
{
    public ContestResults(string contest, double points)
    {
        Contest = contest;
        Points = points;
    }
    public string Contest { get; set; }
    public double Points { get; set; }
}