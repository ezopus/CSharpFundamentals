using System.Text.RegularExpressions;

string[] input = Console.ReadLine().Split('|');

string firstPattern = @"([\$\#\%\&\*])(?<first>[A-Z]+)\1";
string secondPattern = @"(?<char>\d{2}):(?<length>\d{2})";
string[] thirdPattern = input[2].Split(" ");
Match firstPart = Regex.Match(input[0], firstPattern);
string capitalLetters = firstPart.Groups["first"].Value;
MatchCollection secondPartPairs = Regex.Matches(input[1], secondPattern);
List<string> secondPartUniquePairs = new List<string>();
foreach (Match pairs in secondPartPairs)
{
    if (!secondPartUniquePairs.Contains(pairs.Value))
    {
        secondPartUniquePairs.Add(pairs.Value);
    }
}

for (int i = 0; i < capitalLetters.Length; i++)
{
    char capitalLetter = capitalLetters[i];
    
    foreach (var match in secondPartUniquePairs)
    {
        int currentASCII = int.Parse(match.Substring(0,2));
        int currentLength = int.Parse(match.Substring(3,2)) + 1;
        if (capitalLetter == currentASCII)
        {
            foreach (string s in thirdPattern)
            {
                if (s[0] == capitalLetter && s.Length == currentLength)
                {
                    Console.WriteLine(s);
                    break;
                }
            }
        }
    }
}




/*
sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww The Parahaos


Urgent"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig
 */

