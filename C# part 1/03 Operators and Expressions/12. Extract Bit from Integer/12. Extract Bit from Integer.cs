using System;

//Problem 12. Extract Bit from Integer
//r• Write an expression that extracts from given integer
//n  the value of given bit at index  p .

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer (-2,147,483,648 to 2,147,483,647): ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index (0 to 31): ");
        byte bitIndex = byte.Parse(Console.ReadLine());

        num >>= bitIndex;
        num &= 1;

        Console.WriteLine(num);        
    }
}

