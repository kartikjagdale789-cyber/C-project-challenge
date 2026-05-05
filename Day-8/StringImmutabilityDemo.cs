using System;

class StringImmutabilityDemo
{
    static void Main()
    {
        string str = "Hello";

        Console.WriteLine("Original String: " + str);

        str = str + " World";

        Console.WriteLine("Modified String: " + str);
    }
}