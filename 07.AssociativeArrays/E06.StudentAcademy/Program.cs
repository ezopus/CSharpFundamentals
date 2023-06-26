var students = new Dictionary<string, List<double>>();
int numberOfStudents = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfStudents; i++)
{
    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());
    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName, new List<double>());
    }
    students[studentName].Add(studentGrade);
}

// foreach (var s in students)
// {
//     if (s.Value.Average() < 4.5)
//     {
//         students.Remove(s.Key);
//     }
// }

foreach (var s in students)
{
    if (s.Value.Average() >= 4.5)
    {
        Console.WriteLine($"{s.Key} -> {s.Value.Average():f2}");
    }
}