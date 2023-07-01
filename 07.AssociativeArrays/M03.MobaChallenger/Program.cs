var players = new Dictionary<string, List<PositionSkill>>();
string input = "";
while ((input = Console.ReadLine()) != "Season end")
{
    string[] tokens = input.Replace(" -> ", " ").Split(" ");
    string playerOne = tokens[0];
    string PositionOrDuel = tokens[1];
    if (PositionOrDuel == "vs")
    {
        string playerTwo = tokens[2];
        if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
        {
            bool HasMatchingPositions = players[playerOne].Exists(x => players[playerTwo].Exists(y => x.Position == y.Position));
            int totalSkillPlayerOne = players[playerOne].Sum(x => x.Skill);
            int totalSkillPlayerTwo = players[playerTwo].Sum(x => x.Skill);
            if (HasMatchingPositions)
            {
                if (totalSkillPlayerOne > totalSkillPlayerTwo)
                {
                    players.Remove(playerTwo);
                }
                if (totalSkillPlayerOne < totalSkillPlayerTwo)
                {
                    players.Remove(playerOne);
                }
            }
        }
    }
    else
    {
        int skill = int.Parse(tokens[2]);
        if (players.ContainsKey(playerOne))
        {
            PositionSkill current = players[playerOne].Find(x => x.Position == PositionOrDuel);
            if (current != null)
            {
                if (current.Skill < skill)
                {
                    current.Skill = skill;
                }
            }
            else
            {
                PositionSkill newSkill = new PositionSkill(playerOne, PositionOrDuel, skill);
                players[playerOne].Add(newSkill);
            }
        }
        else
        {
            players.Add(playerOne, new List<PositionSkill>());
            PositionSkill newSkill = new PositionSkill(playerOne,PositionOrDuel, skill);
            players[playerOne].Add(newSkill);
        }
    }
}

foreach (var p in players.OrderByDescending(x => x.Value.Sum(y => y.Skill)).ThenBy(x => x.Key))
{
    Console.WriteLine($"{p.Key}: {p.Value.Sum(x => x.Skill)} skill");
    foreach (var s in p.Value.OrderByDescending(x => x.Skill).ThenBy(x => x.Position))
    {
        Console.WriteLine($"- {s.Position} <::> {s.Skill}");
    }
}
public class PositionSkill
{
    public PositionSkill(string name, string position, int skill)
    {
        Name = name;
        Position = position;
        Skill = skill;
    }
    public string Name { get; set; }
    public string Position { get; set; }
    public int Skill { get; set; }
}