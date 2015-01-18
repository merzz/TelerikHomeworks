using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        //the "?" after the data type represent their entire underlying value range
        //+ the nullable type value

        Console.WriteLine(intVar);
        Console.WriteLine(doubleVar);
        Console.WriteLine(intVar + 5);
        Console.WriteLine(doubleVar + 5);
        //even after addition the value of a null is still null
        intVar = 5;
        //only when explicitly assigned does the null value changes
        Console.WriteLine(intVar);
    }
}

