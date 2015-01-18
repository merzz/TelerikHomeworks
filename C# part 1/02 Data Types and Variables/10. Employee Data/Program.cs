using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Pe6o";
        string lastName = "Pe6ov";
        byte age = 57;
        //byte has a range of 0 to 255, which is more than enough for age
        char gender = 't';
        string personalId = "12345";
        //personal ID probably will not be used for any calculations and it doesn`t have a limit
        //so string is most appropriate
        int uniqueId = 27560000;
        //unique ID is in the range of 27560000…27569999 so integer will suffize,
        //it is likely that it will be used for comparison or arrangment

        Console.WriteLine(firstName+" "+lastName);
        Console.WriteLine("age = "+age);
        Console.WriteLine("gender = "+gender);
        Console.WriteLine("personal ID = "+personalId);
        Console.WriteLine("unique ID = "+uniqueId);
    }
}

