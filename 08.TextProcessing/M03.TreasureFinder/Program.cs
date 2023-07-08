using System.Text;

int[] key = Console
    .ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
string input = "";
StringBuilder decrypted = new StringBuilder();
while ((input = Console.ReadLine()) != "find")
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
    {
        char current = input[i];
        char decryptedChar = (char)((int)current - key[counter]);
        decrypted.Append(decryptedChar);
        counter++;
        if (counter == key.Length)
        {
            counter = 0;
        }
    }
    int itemStart = decrypted.ToString().IndexOf('&');
    int itemEnd = decrypted.ToString().LastIndexOf('&');
    string item = decrypted.ToString().Substring(itemStart + 1, itemEnd - itemStart - 1);
    int coordinatesStart = decrypted.ToString().IndexOf('<');
    int coordinatesEnd = decrypted.ToString().IndexOf('>');
    string coordinates = decrypted.ToString().Substring(coordinatesStart + 1, coordinatesEnd - coordinatesStart - 1);
    Console.WriteLine($"Found {item} at {coordinates}");
    decrypted.Clear();
}
