using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        //254 in binary is 1111 1110, so in hex we have F (1111 in binary and 16 in decimal) for the left 4 bits and E (1110 in binary, 15 in decimal) for the right 4 bits.
        int a = 0xfe;
        Console.WriteLine(a);
    }
}

