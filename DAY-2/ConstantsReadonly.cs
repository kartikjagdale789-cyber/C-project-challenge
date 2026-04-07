using System;

class ConstantsReadonly
{
    const double PI = 3.14;   // Constant
    readonly int value;       // Readonly

    public ConstantsReadonly()
    {
        value = 100; // Assigned in constructor
    }

    static void Main()
    {
        ConstantsReadonly obj = new ConstantsReadonly();

        Console.WriteLine("Constant PI: " + PI);
        Console.WriteLine("Readonly Value: " + obj.value);
    }
}