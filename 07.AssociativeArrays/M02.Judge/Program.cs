var contests = new Dictionary<string, List<StudentResults>>();
string input = "";
while ((input = Console.ReadLine()) != "no more time")
{
    string[] tokens = input
        .Split(" -> ")
        .ToArray();
    string username = tokens[0];
    string contestName = tokens[1];
    double points = double.Parse(tokens[2]);
    if (contests.ContainsKey(contestName))  //check if contest exists
    {
        StudentResults current = contests[contestName].Find(x => x.Username == username);  //get current user
        if (current != null) //check if score is null
        {
            if (current.Points < points)  //update score
            {
                current.Points = points;
            }
        }
        else
        {
            contests[contestName].Add(new StudentResults(username, points)); //add new user and points
        }
    }
    else
    {
        contests.Add(contestName, new List<StudentResults>());   //add new contest
        contests[contestName].Add(new StudentResults(username, points));  //add new user and points
    }
}

var individualRank = new Dictionary<string, double>();   

//summing all points for each user
foreach (var allUserResults in contests.Values)               //go through all users and scores
{
    foreach (var oneUser in allUserResults)                   //iterate for each user
    {
        if (!individualRank.ContainsKey(oneUser.Username))      //if first iteration for username, add to new dict
        {
            individualRank.Add(oneUser.Username, oneUser.Points);
        }
        else
        {
            individualRank[oneUser.Username] += oneUser.Points;   //if existing username, add to previous points
        }
    }
} 

//print all contests
foreach (var contest in contests)      
{
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    int i = 1;
    foreach (var user in contest.Value.OrderByDescending(x => x.Points).ThenBy(x => x.Username))
    {
        Console.WriteLine($"{i}. {user.Username} <::> {user.Points}");
        i++;
    }
}

//print individual standings
Console.WriteLine("Individual standings:");
int counter = 1;
foreach (var ind in individualRank.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
        Console.WriteLine($"{counter}. {ind.Key} -> {ind.Value}");
        counter++;
}

public class StudentResults
{
    public StudentResults(string username, double points)
    {
        Username = username;
        Points = points;
    }
    public string Username { get; set; }
    public double Points { get; set; }
}