var products = new Dictionary<string, Product>(); 
string input = "";
while ((input = Console.ReadLine()) != "buy")
{
    string[] oneProduct = input.Split(" ");
    string name = oneProduct[0];
    double price = double.Parse(oneProduct[1]);
    int amount = int.Parse(oneProduct[2]);
    if (products.ContainsKey(name))
    {
        products[name].Price = price;
        products[name].Amount += amount;
    }
    else
    {
        Product product = new Product(name, price, amount);
        products.Add(name, product);
    }
}

foreach (var product in products)
{
    Console.WriteLine($"{product.Key} -> {product.Value.Amount * product.Value.Price:f2}");
}
public class Product
{
    public Product(string name, double price, int amount)
    {
        Name = name;
        Price = price;
        Amount = amount;
    }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
}