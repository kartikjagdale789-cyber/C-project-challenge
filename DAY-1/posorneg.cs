using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is Negative");
        }
        else
        {
            Console.WriteLine("The number is Zero");
        }
    }
}
