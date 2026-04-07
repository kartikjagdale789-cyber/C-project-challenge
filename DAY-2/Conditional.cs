using System;

class Conditional
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("Positive Number");
        else if (number < 0)
            Console.WriteLine("Negative Number");
        else
            Console.WriteLine("Zero");
    }
}