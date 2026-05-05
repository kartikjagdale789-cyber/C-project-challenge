using System;

delegate void Notify();

class Program
{
    static void Message1()
    {
        Console.WriteLine("Message 1");
    }

    static void Message2()
    {
        Console.WriteLine("Message 2");
    }

    static void Main()
    {
        Notify n;

        n = Message1;
        n += Message2;

        n();
    }
}