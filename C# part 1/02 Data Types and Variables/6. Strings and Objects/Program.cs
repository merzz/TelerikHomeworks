using System;

class StringsObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object phrase = hello + " " + world;
        string greeting = (string)phrase;
        Console.WriteLine(greeting);
    }
}

