using System;
//### Problem * 13. Merge sort
//*	Write a program that sorts an array of integers using the [Merge sort](http://en.wikipedia.org/wiki/Merge_sort) algorithm (find it in Wikipedia).
class Program
{
    static void Main()
    {
        Console.Write("Enter array (members delimited by space: ");
        string[] arrStr = Console.ReadLine().Split(' ');
        int[] arr = new int[arrStr.Length];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }


    }
}

