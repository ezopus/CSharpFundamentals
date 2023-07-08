string[] input = Console
    .ReadLine()
    .Split(", ");
foreach (string username in input)
{
    if (username.Length >= 3 && username.Length <= 16)
    {
        if (username.All(singleChar => char.IsLetterOrDigit(singleChar)
                                       || singleChar == '-'
                                       || singleChar == '_') == true)
        {
            Console.WriteLine(username);
        }
    }
}