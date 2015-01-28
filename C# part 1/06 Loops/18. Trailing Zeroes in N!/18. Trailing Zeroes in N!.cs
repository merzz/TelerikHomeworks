using System;
using System.Numerics;

//Problem 18.* Trailing Zeroes in N!
//• Write a program that calculates with how many zeroes the factorial
//of a given number  n  has at its end.
//• Your program should work well for very big numbers, e.g.  n=100000 .

//Examples:
//n       trailing zeroes of n!       explaination
//10      2                           3628800 
//20      4                           2432902008176640000 
//100000  24999                       think why 

class Trailing_Zeroes_in_Nfact
{
    //static void Main()
    //{
    //start:
    //    Console.Write("Enter integer: ");
    //    ulong num = ulong.Parse(Console.ReadLine());
    //    BigInteger factorial = 1;

    //    do
    //    {
    //        factorial *= num;
    //        num--;
    //    }
    //    while (num != 0);

    //    uint i = 0;
    //    BigInteger remainder = factorial % 10;

    //    if (factorial > 24)    //because the cycle doesn`t work for facotrials less than 5 and anyway they don`t have trailing zeros
    //    {
    //        while (remainder == 0)
    //        {
    //            i++;
    //            remainder = factorial % 10;
    //            factorial /= 10;
    //        }
    //        i--;
    //    }
    //    Console.WriteLine("Trailing zeros: " + i);
    //    goto start;
    //}

    static void Main()
    {
        //of course theres a simpler method than brute force calculation
        //if you divide the original number by 5, the first result is trailing zeros from all 5s (5^1),
        //then divide again this result by 5, you get the zeros from all the 25s (5^2) and so on until you get zero result
        //for example if you try to calculate !101. You need to find all the 5s in it. it is easy 101/5 = 20.
        //So you have 20 trailing digits. But we missed 25s. They are powers of 5 which will also give trailing zeros.
        //Just delete 101/25 = 4. 
    start:
        Console.Write("Enter integer: ");
        ulong num = ulong.Parse(Console.ReadLine());
        ulong zeroCount = 0;

        do
        {
            zeroCount += num / 5;
            num = num / 5;
        }
        while (num >= 5);
        Console.WriteLine(zeroCount);
        goto start;
    }
}
