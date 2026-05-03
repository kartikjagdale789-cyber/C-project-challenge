using System;

class SumNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = n * (n + 1) / 2;

        Console.WriteLine("Sum = " + sum);
    }
}