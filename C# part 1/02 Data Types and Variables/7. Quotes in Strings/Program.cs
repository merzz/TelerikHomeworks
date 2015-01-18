using System;

class QuotesInStrings
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties.";
        string b = @"The ""use"" of quotations causes difficulties.";
        string c = a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

