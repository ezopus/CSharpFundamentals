int encryptionKey = int.Parse(Console.ReadLine());
int charCounter = int.Parse(Console.ReadLine());
string phrase = "";
while (charCounter > 0)
{
    char input = char.Parse(Console.ReadLine());
    char decrypted = (char)((int)input + encryptionKey);
    phrase += decrypted.ToString();
    charCounter--;
}

Console.WriteLine(phrase);