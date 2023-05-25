int day = int.Parse(Console.ReadLine());
string[] dayOfWeek =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
if (day > 0 && day < 8)
{
    Console.WriteLine(dayOfWeek[day - 1]);
}
else Console.WriteLine("Invalid day!");