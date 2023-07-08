using System.Text;

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    StringBuilder sb = new StringBuilder();
    char[] inputArray = input.ToCharArray();
    for (int i = inputArray.Length - 1; i >= 0; i--)
    {
        sb.Append(inputArray[i]);
    }
    Console.WriteLine($"{input} = {sb}");
}

