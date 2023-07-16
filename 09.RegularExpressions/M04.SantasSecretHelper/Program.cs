using System.Text.RegularExpressions;

int santaKey = int.Parse(Console.ReadLine());
List<string> goodKids = new List<string>();
string input = "";
while((input = Console.ReadLine()) != "end")
{
    string currentName = input;
    string decryptedName = "";
    foreach (char c in currentName)
    {
        decryptedName += (char)(c - santaKey);
    }
    string decryptPattern = @"[@](?<name>[A-Za-z]+)[^\@\-\!\:\>]+[!](?<behaviour>[A-Z])[!]";
    Match currentKid = Regex.Match(decryptedName, decryptPattern);
    if (currentKid.Groups["behaviour"].Value == "G")
    {
        goodKids.Add(currentKid.Groups["name"].Value);
    }
}

Console.WriteLine(string.Join(Environment.NewLine, goodKids));
