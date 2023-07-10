int numberOfCars = int.Parse(Console.ReadLine());
Dictionary<string, Car> cars = new Dictionary<string, Car>();
for (int i = 0; i < numberOfCars; i++)
{
    string[] tokens = Console
        .ReadLine()
        .Split("|");
    string carName = tokens[0];
    double mileage = double.Parse(tokens[1]);
    double fuel = double.Parse(tokens[2]);
    Car currentCar = new Car(mileage, fuel);
    cars.Add(carName, currentCar);
}

string input = "";
while ((input = Console.ReadLine()) != "Stop")
{
    string[] commands = input.Split(" : ");
    string action = commands[0];
    string carName = commands[1];
    switch (action)
    {
        case "Drive":
            double distance = double.Parse(commands[2]);
            double fuel = double.Parse(commands[3]);
            DriveCar(carName, distance, fuel);
            break;
        case "Refuel":
            fuel = double.Parse(commands[2]);
            FuelCar(carName, fuel);
            break;
        case "Revert":
            double kilometers = double.Parse(commands[2]);
            RevertCar(carName, kilometers);
            break;
        default:
            break;
    }
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
}

void DriveCar(string carName, double distance, double fuel)
{
    if (cars[carName].Fuel >= fuel)
    {
        cars[carName].Fuel -= fuel;
        cars[carName].Mileage += distance;
        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
    }
    else
    {
        Console.WriteLine("Not enough fuel to make that ride");
    }
    if (cars[carName].Mileage >= 100000)
    {
        cars.Remove(carName);
        Console.WriteLine($"Time to sell the {carName}!");
    }
}
void FuelCar(string carName, double fuel)
{
    if (cars[carName].Fuel + fuel > 75)
    {
        fuel = 75 - cars[carName].Fuel;
        cars[carName].Fuel = 75;
    }
    else
    {
        cars[carName].Fuel += fuel;
    }
    Console.WriteLine($"{carName} refueled with {fuel} liters");
}
void RevertCar(string carName, double kilometers)
{
    if (cars[carName].Mileage - kilometers > 10000)
    {
        cars[carName].Mileage -= kilometers;
        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
    }
    else
    {
        cars[carName].Mileage = 10000;
    }
}
public class Car
{
    public Car(double mileage, double fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }
    public double Mileage { get; set; }
    public double Fuel { get; set; }
}