using System;

static class Extension
{
    public static int Square(this int num)
    {
        return num * num;
    }
}

class Program
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Square: " + n.Square());
    }
}