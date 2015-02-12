using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter array (members delimited by space: ");
        string[] arrStr = Console.ReadLine().Split(' ');
        int[] arr = new int[arrStr.Length];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }

        int count = CountNumInArr(num, arr);
        Console.WriteLine("Number {0} is found {1} times", num, count);
    }

    static int CountNumInArr(int num, int[] collection)
    {
        int count = 0;
        foreach (var item in collection)
        {
            if (item == num)
            {
                count++;
            }
        }

        return count;
    }
}