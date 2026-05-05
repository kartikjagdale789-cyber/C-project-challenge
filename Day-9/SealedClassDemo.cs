using System;

sealed class Vehicle
{
    public void Show()
    {
        Console.WriteLine("This is a sealed class");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle();
        v.Show();
    }
}