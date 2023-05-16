int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string day = Console.ReadLine();
double totalPrice = 0;

if (typeOfGroup == "Students")
{
    switch (day)
    {
        case "Friday":
            totalPrice = countOfPeople * 8.45;
            break;
        case "Saturday":
            totalPrice = countOfPeople * 9.8;
            break;
        case "Sunday":
            totalPrice = countOfPeople * 10.46;


            break;
    }
}
else if (typeOfGroup == "Business")
{
    switch (day)
    {
        case "Friday":
            totalPrice = countOfPeople * 10.9;
            break;
        case "Saturday":
            totalPrice = countOfPeople * 15.6;
            break;
        case "Sunday":
            totalPrice = countOfPeople * 16;
            break;
    }
}
else if (typeOfGroup == "Regular")
{
    switch (day)
    {
        case "Friday":
            totalPrice = countOfPeople * 15;
            break;

        case "Saturday":
            totalPrice = countOfPeople * 20;
            break;
        case "Sunday":
            totalPrice = countOfPeople * 22.5;
            break;
    }
}
if (typeOfGroup == "Students" && countOfPeople >= 30)
{
    totalPrice *= 0.85;
}
if (typeOfGroup == "Business" && countOfPeople >= 100)
{
    totalPrice = totalPrice - (totalPrice / countOfPeople * 10);
}
if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
{
    totalPrice *= 0.95;
}
Console.WriteLine($"Total price: {totalPrice:f2}");