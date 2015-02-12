using System;
using System.Collections.Generic;
////### Problem 11. Adding polynomials
////*	Write a method that adds two polynomials.
////*	Represent them as arrays of their coefficients.
class Program
{
    static void Main()
    {
        // I made this task a lot more complex than required. It works for any given order of
        // polynomial input (you don`t have to start with variable to max power, you can enter 
        // two times the same term variable with different constants. You can also enter more than one variable
        // For example: 3xy^2 + 2x + 2xy + 1
        Console.WriteLine("\nEnter polynomial 1 data:\n");
        List<string>[] poly1 = PolyInput();
        Console.WriteLine("\nEnter polynomial 2 data:\n");
        List<string>[] poly2 = PolyInput();

        Console.Write("\nPolynomial 1: ");
        PrintPoly(poly1);
        Console.Write("\nPolynomial 2: ");
        PrintPoly(poly2);
        Console.Write("\nSum is:");
        PrintPoly(AddPolys(poly1,poly2));
    }

    static List<string>[] AddPolys(List<string>[] poly0, List<string>[] poly1)
    {
        List<string>[] result = new List<string>[2];    // array of lists to store results
        result[0] = new List<string>(); // first lists stores constants
        result[1] = new List<string>(); // variables


        for (int idx0 = 0; idx0 < poly0[0].Count; idx0++)   // cycles through all vars in poly 0
        {
            int res = int.Parse(poly0[0][idx0]);
            for (int idx1 = 0; idx1 < poly1[1].Count; idx1++)   // cycles through all vars in poly 1
            {
                if (poly0[1][idx0] == poly1[1][idx1])
                {
                    // if any variables are matching sum their constants
                    res += int.Parse(poly1[0][idx1]);
                }
                else
                {
                    // add next result term from second poly if its current term variables have no equals in first poly
                    bool isNew = true;
                    foreach (var item in poly0[1])
                    {
                        if (item == poly1[1][idx1])
                        {
                            isNew = false;
                            break;
                        }
                    }

                    if (isNew)
                    {
                        result[0].Add(poly1[0][idx1]);
                        result[1].Add(poly1[1][idx1]);
                    }
                }
            }

            // add next summed term to result
            result[0].Add(res.ToString());
            result[1].Add(poly0[1][idx0]);
        }

        return result;
    }

    static List<string>[] PolyInput()
    {
        // we define our polynomial as an array of two lists. the first list will store the constants
        // the second list will store the variables for the constant at the same index in the first list
        // ex. 3x^2 + 2x^1 + 1
        // list 0 { 3, 2 , 1}, list 1 {"x^2", "x^1", "")

        List<string>[] inputPoly = new List<string>[2];
        inputPoly[0] = new List<string>();  // constants
        inputPoly[1] = new List<string>();  // variables

        Console.Write("Enter polynom terms count: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter polynom term {0} constant: ", i);
            inputPoly[0].Add(Console.ReadLine());
            Console.Write("Enter polynom term {0} variables: ", i);
            inputPoly[1].Add(Console.ReadLine());
        }

        return inputPoly;
    }

    static void PrintPoly(List<string>[] poly)
    {
        for (int i = poly[0].Count-1; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{0}{1} + ", poly[0][i], poly[1][i]);
            }
            else
            {
                Console.Write("{0}{1}\n", poly[0][i], poly[1][i]);
            }
        }
    }
}

