int numberOfPieces = int.Parse(Console.ReadLine());
var pieces = new Dictionary<string, Piece>();
for (int i = 0; i < numberOfPieces; i++)
{
    string[] tokens = Console.ReadLine().Split("|");
    string piece = tokens[0];
    string composer = tokens[1];
    string key = tokens[2];
    Piece currentPiece = new Piece(composer, key);
    pieces.Add(piece, currentPiece);
}

string input;
while ((input = Console.ReadLine()) != "Stop")
{
    string[] commands = input.Split("|");
    string command = commands[0];
    string piece = commands[1];
    switch (command)
    {
        case "Add":
            string composer = commands[2];
            string key = commands[3];
            AddPiece(piece, composer, key);
            break;
        case "Remove":
            RemovePiece(piece);
            break;
        case "ChangeKey":
            key = commands[2];
            ChangeKey(piece, key);
            break;
        default:
            break;
    }
}

foreach (var piece in pieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}

void AddPiece(string piece, string composer, string key)
{
    if (pieces.ContainsKey(piece))
    {
        Console.WriteLine($"{piece} is already in the collection!");
    }
    else
    {
        Piece newPiece = new Piece(composer, key);
        pieces.Add(piece, newPiece);
        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
    }
}

void RemovePiece(string piece)
{
    if (pieces.ContainsKey(piece))
    {
        pieces.Remove(piece);
        Console.WriteLine($"Successfully removed {piece}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
    }
}

void ChangeKey(string piece, string key)
{
    if (pieces.ContainsKey(piece))
    {
        pieces[piece].Key = key;
        Console.WriteLine($"Changed the key of {piece} to {key}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
    }
}

class Piece
{
    public Piece(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }
    public string Key { get; set; }
}