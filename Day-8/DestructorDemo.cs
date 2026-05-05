using System;

class Demo
{
    public Demo()
    {
        Console.WriteLine("Constructor called");
    }

    ~Demo()
    {
        Console.WriteLine("Destructor called");
    }
}

class DestructorDemo
{
    static void Main()
    {
        Demo obj = new Demo();
        Console.WriteLine("Program End");
    }
}