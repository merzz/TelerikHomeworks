using System;
////### Problem 07. Reverse number
////*	Write a method that reverses the digits of given decimal number.

////_Example:_

////| input | output |
////|:-----:|:------:|
////| 256   | 652    |
class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDigits(num));
    }

    static int ReverseDigits(int num)
    {
        char[] digits = num.ToString().ToCharArray();
        Array.Reverse(digits);
        string res = "";
        for (int i = 0; i < digits.Length; i++)
        {
            res += digits[i];
        }

        return int.Parse(res);
    }
}

