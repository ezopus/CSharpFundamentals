using System.Text.RegularExpressions;

string regex = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

string input = Console.ReadLine();
MatchCollection food = Regex.Matches(input, regex);

int days = 0;
int totalCalories = food.Sum(x => int.Parse(x.Groups["calories"].Value));

while (totalCalories - 2000 >= 0)
{
    totalCalories -= 2000;
    days++;
}

Console.WriteLine($"You have food to last you for: {days} days!");
foreach (Match item in food)
{
    string name = item.Groups["name"].Value;
    string date = item.Groups["date"].Value;
    string calories = item.Groups["calories"].Value;
    Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
}
