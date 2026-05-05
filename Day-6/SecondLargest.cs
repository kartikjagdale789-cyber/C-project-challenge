using System;

class SecondLargest
{
    static void Main()
    {
        int[] arr = { 10, 50, 30, 90, 40 };

        int largest = arr[0];
        int second = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                second = num;
            }
        }

        Console.WriteLine("Second Largest: " + second);
    }
}