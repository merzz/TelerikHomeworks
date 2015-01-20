using System;

//Problem 16.** Bit Exchange (Advanced)
//• Write a program that exchanges bits  {p, p+1, …, p+k-1}  
//with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
//• The first and the second sequence of bits may not overlap.

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        string numInput = Console.ReadLine();
        uint num = 0;

        Console.Write("Enter bit p: ");
        string pInput = Console.ReadLine();
        byte p = 0;

        Console.Write("Enter bit q: ");
        string qInput = Console.ReadLine();
        byte q = 0;

        Console.Write("Enter range k: ");
        string kInput = Console.ReadLine();
        byte k = 0;

        if (!(uint.TryParse(numInput, out num) && byte.TryParse(pInput, out p) && byte.TryParse(qInput, out q) && byte.TryParse(kInput, out k)))
        {
            Console.WriteLine("Out of range!!!!!!! Invalid input values, possibly too big or too small or not integers!");
        }

        else if (Math.Abs(p - q) < k)
        {
            Console.WriteLine("Overlapping bit ranges!!!!!!");
        }

        else if ((p + k - 1 > 31) || (q + k - 1 > 31))
        {
            Console.WriteLine("Exchange bits out of range!!!!!!");
        }

        else
        {
            uint resultNum = num;

            for (int i = 0; i < k; i++)
            {
                resultNum = (((num >> (p + i)) & 1) == 1) ? ((uint)(1 << (q + i)) | resultNum) : ((uint)(~(1 << (q + i))) & resultNum);
            }

            for (int i = 0; i < k; i++)
            {
                resultNum = (((num >> q + i) & 1) == 1) ? ((uint)(1 << (p + i)) | resultNum) : ((uint)(~(1 << (p + i))) & resultNum);
            }

            Console.WriteLine("Result is " + resultNum);
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(resultNum, 2).PadLeft(32, '0'));
        }
    }
}

