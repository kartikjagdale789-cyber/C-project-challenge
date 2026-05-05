using System;

class NamedArgumentsDemo
{
    static void Show(string name, int age)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Show(age: 20, name: "Ajay");
    }
}