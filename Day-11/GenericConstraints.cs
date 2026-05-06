using System;

class Test<T> where T : class
{
    public void Display(T value)
    {
        Console.WriteLine("Value: " + value);
    }
}

class Program
{
    static void Main()
    {
        Test<string> t = new Test<string>();
        t.Display("Hello Generics");
    }
}