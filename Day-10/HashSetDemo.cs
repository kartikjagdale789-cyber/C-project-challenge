using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(20); // duplicate ignored
        numbers.Add(30);

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}