using System;

class TupleDemo
{
    static void Main()
    {
        var person = (Id: 1, Name: "Ajay", Age: 20);
        Console.WriteLine($"ID: {person.Id}");
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
    }
}