using System;

class SortArray
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 3 };

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}