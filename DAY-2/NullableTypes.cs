using System;

class NullableTypes
{
    static void Main()
    {
        int? num = null;

        Console.WriteLine("Nullable value: " + num);

        num = 10;
        Console_toggleLine("Now value: " + num);
    }
}