using System;

class OutRefDemo
{
    static void ShowRef(ref int x)
    {
        x = x + 10;
    }

    static void ShowOut(out int y)
    {
        y = 50;
    }

    static void Main()
    {
        int a = 20;
        int b;

        ShowRef(ref a);
        ShowOut(out b);

        Console.WriteLine("Ref value: " + a);
        Console.WriteLine("Out value: " + b);
    }
}