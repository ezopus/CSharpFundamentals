int numberOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());
int totalCourses = 0;

while (numberOfPeople > 0)
{
    numberOfPeople -= capacity;
    totalCourses++;
}
Console.WriteLine(totalCourses);