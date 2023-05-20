int lineCount = int.Parse(Console.ReadLine());
bool isOpened = false;
bool isBalanced = true;
for (int i = 0; i < lineCount; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        if (isOpened)
        {
            isBalanced = false;
        }
        isOpened = true;
    }
    else if (input == ")")
    {
        if (isOpened)
        {
            isOpened = false;
        }
        else
        {
            isBalanced = false;
        }
    }
}

if (isOpened)
{
    isBalanced = false;
}

if (isBalanced)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}