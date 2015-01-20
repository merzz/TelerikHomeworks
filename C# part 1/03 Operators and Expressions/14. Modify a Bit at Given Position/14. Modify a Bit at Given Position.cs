using System;

//Problem 14. Modify a Bit at Given Position
//• We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
//• Write a sequence of operators (a few lines of C# code) that modifies  n  to hold 
//the value  v  at the position  p  from the binary representation of  n  while
//preserving all other bits in  n .

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer (-2,147,483,648 to 2,147,483,647): ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index (0 to 31): ");
        byte bitIndex = byte.Parse(Console.ReadLine());
        Console.Write("Enter bit value (0 to 31): ");
        int bitValue = byte.Parse(Console.ReadLine());

        num = (bitValue == 1) ? num | (1 << bitIndex) : num & ~(1 << bitIndex);
        Console.WriteLine("Result: " + num);
    }
}

