using System;

//Problem 11. Bitwise: Extract Bit #3
//• Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
//• The bits are counted from right to left, starting from bit  #0 .
//• The result of the expression should be either  1  or  0 .

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Enter an integer (-2,147,483,648 to 2,147,483,647): ");
        int num = int.Parse(Console.ReadLine());

        num >>= 3;
        num &= 1;

        Console.WriteLine(num);
    }
}

