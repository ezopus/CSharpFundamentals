string[] allPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
string[] allProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

List<Product> products = new List<Product>();
List<Person> persons = new List<Person>();
foreach (string p in allPeople)
{
    string[] inputPeople = p.Split("=", StringSplitOptions.RemoveEmptyEntries);
    string name = inputPeople[0];
    double money = double.Parse(inputPeople[1]);
    Person person = new Person(name, money);
    persons.Add(person);
}
foreach (string s in allProducts)
{
    string[] inputProducts = s.Split("=", StringSplitOptions.RemoveEmptyEntries);
    string name = inputProducts[0];
    double cost = double.Parse(inputProducts[1]);
    Product product = new Product(name, cost);
    products.Add(product);
}

string input = "";
while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(" ");
    string buyer = tokens[0];
    string item = tokens[1];
    Person currentBuyer = persons.Find(x => x.Name == buyer);
    Product currentProduct = products.Find(x => x.Name == item);
    if (currentBuyer.Money >= currentProduct.Cost)
    {
        Console.WriteLine($"{currentBuyer.Name} bought {currentProduct.Name}");
        currentBuyer.Product.Add(currentProduct.Name);
        currentBuyer.Money -= currentProduct.Cost;
    }
    else
    {
        Console.WriteLine($"{currentBuyer.Name} can't afford {currentProduct.Name}");
    }
}
foreach (Person person in persons)
{
    Console.Write($"{person.Name} - ");
    if (person.Product.Count > 0)
    {
        Console.Write(string.Join(", ", person.Product));
    }
    else
    {
        Console.WriteLine("Nothing bought");
    }
    Console.WriteLine();
}

class Person
{
    public Person(string name, double money)
    {
        Name = name;
        Money = money;
        Product = new List<string>();
    }
    public string Name { get; set; }
    public double Money { get; set; }
    public List<string> Product { get; set; }
}
class Product
{
    public Product(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
    public string Name { get; set; }
    public double Cost { get; set; }
}