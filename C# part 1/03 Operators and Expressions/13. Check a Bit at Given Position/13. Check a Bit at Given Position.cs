using System;

//Problem 13. Check a Bit at Given Position
//• Write a Boolean expression that returns if the bit at position
//p  (counting from  0 , starting from the right) in given integer 
//number  n , has value of 1.

class CheckBitGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer (-2,147,483,648 to 2,147,483,647): ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index (0 to 31): ");
        byte bitIndex = byte.Parse(Console.ReadLine());

        bool result = (((num >> bitIndex) & 1) == 1);
        Console.WriteLine(result);
    }
}

