using System;

class LargestSmallestArray
{
    static void Main()
    {
        int[] arr = { 15, 22, 8, 45, 3 };

        int largest = arr[0];
        int smallest = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
                largest = num;

            if (num < smallest)
                smallest = num;
        }

        Console.WriteLine("Largest Element: " + largest);
        Console.WriteLine("Smallest Element: " + smallest);
    }
}