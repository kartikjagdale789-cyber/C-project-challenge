using System;

interface IFather
{
    void ShowFather();
}

interface IMother
{
    void ShowMother();
}

class Child : IFather, IMother
{
    public void ShowFather()
    {
        Console.WriteLine("Father method");
    }

    public void ShowMother()
    {
        Console.WriteLine("Mother method");
    }
}

class Program
{
    static void Main()
    {
        Child c = new Child();
        c.ShowFather();
        c.ShowMother();
    }
}