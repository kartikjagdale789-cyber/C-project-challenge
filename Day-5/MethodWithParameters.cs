using System;

class MethodWithParameters
{
    static void Add(int a, int b)
    {
        Console.WriteLine("Sum = " + (a + b));
    }

    static void Main()
    {
        Add(10, 20);
    }
}