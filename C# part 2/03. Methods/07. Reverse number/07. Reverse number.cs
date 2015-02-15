using System;
using System.Collections.Generic;
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
        decimal num = decimal.Parse(Console.ReadLine());

        char[] digits = num.ToString().ToCharArray();
        int dotPosition = Array.IndexOf(digits, '.');

        if (dotPosition > 0)
        {
            string[] parts = num.ToString().Split('.');
            Console.WriteLine(ReverseString(parts[0]) + "." + ReverseString(parts[1]));
        }
        else
        {
        Console.WriteLine(ReverseString(num.ToString()));
        }
    }
    
    static string ReverseString(string thisString)
    {
        char[] digits = thisString.ToCharArray();
        Array.Reverse(digits);
        string res = "";
        for (int i = 0; i < digits.Length; i++)
        {
            res += digits[i];
        }

        return res;
    }
}

