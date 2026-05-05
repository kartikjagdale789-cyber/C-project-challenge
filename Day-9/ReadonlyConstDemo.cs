using System;

class Demo
{
    public const int a = 10;
    public readonly int b;

    public Demo()
    {
        b = 20;
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();

        Console.WriteLine("Const value: " + Demo.a);
        Console.WriteLine("Readonly value: " + d.b);
    }
}