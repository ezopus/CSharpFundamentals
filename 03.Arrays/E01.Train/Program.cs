int numberOfWagons = int.Parse(Console.ReadLine());
int sumOfPeople = 0;
int[] people = new int[numberOfWagons];
for (int i = 0; i < numberOfWagons; i++)
{
    people[i] = int.Parse(Console.ReadLine());
    sumOfPeople += people[i];
}
Console.WriteLine(string.Join(" ", people));
Console.WriteLine(sumOfPeople);