using System;

class  ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter number 1:");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2:");
        double num2 = double.Parse(Console.ReadLine());
        //the initial code lines print the requests
        //and then read the input values to the console
        //for the two numbers: num1 and num2

        double eps = 0.000001;
        //next we define the accuracy toleranse value eps
        bool result;
        //a boolean value will store the result

        result = Math.Abs(num1 - num2) < eps;
        //basically this statement assigns the result of the boolean operation
        //which will be true if the absolute value of the subtraction of the two numbers
        //is less than eps and false if bigger or equal

        Console.WriteLine(result);

        //keep in mind that this method has certain limitations:
        //if we are comapring numbers that are smaller than the epsilon defined it will not work
        //for example: 3.15e-10 and 4.15e-10 - their absolute difference is 1.0e-10 which is smaller than 1.0e-7
        //but it is obvious that they are not meant to be equal in terms of significant digits
        //for more info check: http://www.cprogramming.com/tutorial/floating_point/understanding_floating_point_representation.html
    }
}

