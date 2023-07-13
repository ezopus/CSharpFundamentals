using System.Text.RegularExpressions;

int numberOfBarcodes = int.Parse(Console.ReadLine());
string pattern = @"(\@[#]+)(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])\@[#]+";

for (int i = 0; i < numberOfBarcodes; i++)
{
    string input = Console.ReadLine();
    if (Regex.IsMatch(input, pattern) == true)
    {
        Match newMatch = Regex.Match(input, pattern);
        string productGroup = "";
        foreach (char c in newMatch.Groups["product"].Value)
        {
            if (char.IsDigit(c))
            {
                productGroup += c;
            }
        }

        if (productGroup.Length == 0)
        {
            productGroup = "00";
        }
            
        Console.WriteLine($"Product group: {productGroup}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}

/*
3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##
*/