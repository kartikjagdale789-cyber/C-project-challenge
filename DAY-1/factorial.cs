using System;

class Program
{
    static void Main()
    {
        int n, fact = 1;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
