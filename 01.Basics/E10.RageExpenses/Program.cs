int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice =  double.Parse(Console.ReadLine());
double totalRagePrice = 0;

totalRagePrice += lostGames / 2 * headsetPrice;
totalRagePrice += lostGames / 3 * mousePrice;
totalRagePrice += lostGames / 6 * keyboardPrice;
totalRagePrice += lostGames / 12 * displayPrice;

Console.WriteLine($"Rage expenses: {totalRagePrice:f2} lv.");
