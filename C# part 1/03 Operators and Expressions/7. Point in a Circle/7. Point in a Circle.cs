using System;

//Problem 7. Point in a Circle
//• Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .

class PointCircle
{
    static void Main()
    {
        Console.Write("Enter X ( (+/-)5.0 x 10-324 to (+/-)1.7 x 10308 ): ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y ( (+/-)5.0 x 10-324 to (+/-)1.7 x 10308 ): ");
        double y = double.Parse(Console.ReadLine());

        bool result = (Math.Sqrt(x * x + y * y) <= 2) ? true : false;
        Console.WriteLine("Point is inside circle: " + result);
    }
}

