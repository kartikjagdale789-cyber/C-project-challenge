using System;

class MissingNumberArray
{
    static void Main()
    {
        int[] arr = {1,2,3,5};
        int n = 5;

        int expectedSum = n*(n+1)/2;
        int actualSum = 0;

        foreach(int num in arr)
            actualSum += num;

        int missing = expectedSum - actualSum;

        Console.WriteLine("Missing Number: " + missing);
    }
}
