using System;

//Problem 15.* Bits Exchange
//• Write a program that exchanges bits  3 ,  4  and  5  with bits
//24 ,  25  and  26  of given 32-bit unsigned integer.

class BitsExchange
{
    static void Main()
    {        
        Console.Write("Enter an integer (0 to 4,294,967,295): ");
        uint num = uint.Parse(Console.ReadLine());
        uint resultNum = num;

        resultNum = (((num >> 3) & 1) == 1) ? (uint)((1 << 24) | resultNum) : (uint)((~(1 << 24)) & resultNum);
        resultNum = (((num >> 4) & 1) == 1) ? (uint)((1 << 25) | resultNum) : (uint)((~(1 << 25)) & resultNum);
        resultNum = (((num >> 5) & 1) == 1) ? (uint)((1 << 26) | resultNum) : (uint)((~(1 << 26)) & resultNum);

        resultNum = (((num >> 24) & 1) == 1) ? (uint)((1 << 3) | resultNum) : (uint)((~(1 << 3)) & resultNum);
        resultNum = (((num >> 25) & 1) == 1) ? (uint)((1 << 4) | resultNum) : (uint)((~(1 << 4)) & resultNum);
        resultNum = (((num >> 26) & 1) == 1) ? (uint)((1 << 5) | resultNum) : (uint)((~(1 << 5)) & resultNum);

        Console.WriteLine("Result is " + resultNum);
        Console.WriteLine(Convert.ToString(num,2).PadLeft(32,'0'));
        Console.WriteLine(Convert.ToString(resultNum, 2).PadLeft(32,'0'));
    }
}

