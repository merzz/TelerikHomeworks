using System;
//### Problem 20. Variations of set
//*	Write a program that reads two numbers `N` and `K` and generates all the variations of `K` elements from the set [`1..N`].
class Program
{
    static void Main()
    {
        // doesn`t work when k > 2
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i;
        }

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] +" ");

            int counter = 1;

            for (int ii = 0; ii < n; ii++)
            {
                if (ii == n - 1 && i == n - 1) break;
                if (counter % k == 0 ) { Console.Write("\n" + arr[i] + " "); counter++;}
                if (ii != i) { Console.Write(arr[ii] + " "); counter++; }
            }

            Console.WriteLine();
        }

    }
}

