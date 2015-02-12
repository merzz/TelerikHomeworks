using System;
//### Problem 01. Say Hello
//*	Write a method that asks the user for his name and prints `�Hello, <name>�`
//*	Write a program to test this method.

//_Example:_

//| input |     output    |
//|:-----:|:-------------:|
//| Peter | Hello, Peter! |
class SayHello01
{
    static void Main()
    {
        SayHello();
    }

    static void SayHello()
    {
        Console.Write("Enter name: ");
        Console.WriteLine("Hello, {0}", Console.ReadLine());
    }
}

