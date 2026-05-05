using System;

class OptionalParameterDemo
{
    static void Display(string name = "Ajay")
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        Display();
        Display("Rahul");
    }
}