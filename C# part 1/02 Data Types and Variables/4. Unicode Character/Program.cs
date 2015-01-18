using System;

class UnicodeCharacter
{
    static void Main()
    {
        //first we declare Unicode 42(decimal) using Unicode 002A (hexadecimal)
        char a = '\u002A';
        //we can also do the same in the following way
        char b = '\x002A';
        //we can also do this using the decimal code by casting integer to char type
        char c = (char)42;

        Console.WriteLine("{0} {1} {2}", a, b, c);  //this will print "* * *", essentially the same ascii character
    }
}

