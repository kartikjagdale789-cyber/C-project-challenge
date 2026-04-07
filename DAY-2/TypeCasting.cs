using System;

class TypeCasting
{
    static void Main()
    {
        double num = 10.75;

        // Explicit Casting
        int intNum = (int)num;

        Console.WriteLine("Original Double Value: " + num);
        Console.WriteLine("After Casting to Int: " + intNum);
    }
}