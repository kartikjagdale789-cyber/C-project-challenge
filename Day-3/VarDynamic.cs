using System;

class VarDynamic
{
    static void Main()
    {
        var x = 10;          // fixed type (int)
        dynamic y = 10;      // flexible type

        Console.WriteLine(x);
        Console.WriteLine(y);

        y = "Hello";         // allowed
        Console.WriteLine(y);
    }
}