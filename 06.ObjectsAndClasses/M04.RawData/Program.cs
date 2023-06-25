int numberOfCars = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < numberOfCars; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    string model = input[0];
    int speed = int.Parse(input[1]);
    int power = int.Parse(input[2]);
    int weight = int.Parse(input[3]);
    string type = input[4];
    Cargo cargo = new Cargo(weight, type);
    Engine engine = new Engine(speed, power);
    Car oneCar = new Car(model, cargo, engine);
    cars.Add(oneCar);
}

string command = Console.ReadLine();

if (command == "fragile")
{
    foreach (Car car in cars)
    {
        if (car.Cargo.Weight < 1000 && car.Cargo.Type == "fragile")
        {
            Console.WriteLine(car.Model);
        }
    }
}
else if (command == "flamable")
{
    foreach (Car car in cars)
    {
        if (car.Engine.Power > 250 && car.Cargo.Type == "flamable")
        {
            Console.WriteLine(car.Model);
        }
    }
}

class Car
{
    public Car(string model, Cargo cargo, Engine engine)
    {
        Model = model;
        Cargo = cargo;
        Engine = engine;
    }
    public string Model { get; set; }
    public Cargo Cargo { get; set; }
    public Engine Engine { get; set; }
}

class Cargo
{
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
    public int Weight { get; set; }
    public string Type { get; set; }
}

class Engine
{
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
    public int Speed { get; set; }
    public int Power { get; set; }
}

