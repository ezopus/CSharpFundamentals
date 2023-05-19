decimal N = decimal.Parse(Console.ReadLine());
decimal M = decimal.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int pokeCounter = 0;
decimal originalValue = N;
while (N >= M)
{
    N -= M;
    pokeCounter++;
    if (originalValue / 2 == N && Y > 0 && Y < 10)
    {
        N = (int)N/Y;
    }
        
}
Console.WriteLine(N);
Console.WriteLine(pokeCounter);

