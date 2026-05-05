using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();
    }
}