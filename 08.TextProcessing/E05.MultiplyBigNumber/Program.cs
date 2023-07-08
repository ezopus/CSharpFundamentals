using System.Text;

string bigNumber = Console.ReadLine();
int multiplier = int.Parse(Console.ReadLine());
Console.WriteLine(Multiply(bigNumber, multiplier));
string Multiply(string bigNumber, int multiplier)
{
    if (bigNumber == "0" || multiplier == 0)
    {
        return "0";
    }
    StringBuilder sb = new StringBuilder();
    int carry = 0;
    int digit;
    for (int i = bigNumber.Length - 1; i >= 0; i--)
    {
        digit = (bigNumber[i] - '0') * multiplier;
        digit += carry;
        if (digit > 9)
        {
            carry = digit / 10;
            digit %= 10;
        }
        else
        {
            carry = 0;
        }

        sb.Insert(0, digit);
    }

    if (carry != 0)
    {
        sb.Insert(0, carry);
    }
    return sb.ToString();
}