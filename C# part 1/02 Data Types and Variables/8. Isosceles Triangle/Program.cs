using System;

class IsoscelesTriangle
{
    static void Main()
    {
        //first we set the console output encoding to Unicode
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        //then we assign the copyright symbol unicode hex code to the variable c 
        char c = '\u00a9';

        //following are the 4 lines that write the triangle
        Console.WriteLine("   "+ c + "   ");
        Console.WriteLine("  "+c+" "+c+"  ");
        Console.WriteLine(" "+c+"   "+c+" ");
        Console.WriteLine("{0} {0} {0} {0}",c);
    }
}

