using System;

class ArrayMethodDemo
{
    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };

        PrintArray(numbers);
    }
}