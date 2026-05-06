using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("Sum: " + add(5, 3));

        Action<string> print = msg => Console.WriteLine(msg);
        print("Hello C#");

        Predicate<int> isEven = n => n % 2 == 0;
        Console.WriteLine("Is Even: " + isEven(10));
    }
}