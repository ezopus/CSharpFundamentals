var courses = new Dictionary<string, List<string>>();
string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] tokens = input.Split(" : ");
    string courseName = tokens[0];
    string student = tokens[1];
    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>());
    }
    courses[courseName].Add(student);
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    foreach (string s in course.Value)
    {
        Console.WriteLine($"-- {s}");
    }
}