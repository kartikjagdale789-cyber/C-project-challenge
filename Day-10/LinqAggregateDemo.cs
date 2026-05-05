using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };

        int result = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum: " + result);
    }
}