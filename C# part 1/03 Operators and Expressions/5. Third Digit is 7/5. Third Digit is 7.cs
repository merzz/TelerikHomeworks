using System;

//Problem 5. Third Digit is 7?
//• Write an expression that checks for given integer if its third digit from right-to-left is  7 .

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter an integer (-2,147,483,648 to 2,147,483,647): ");
        int num = int.Parse(Console.ReadLine());

        bool result = ((((num / 100) + 3) % 10) == 0) ? true : false;

        Console.WriteLine("Third digit is 7: " + result);
    }
}

