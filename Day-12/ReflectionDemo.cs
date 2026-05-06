using System;
using System.Reflection;

class Student
{
    public int Id;
    public string Name;

    public void Display()
    {
        Console.WriteLine("Student Method");
    }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Student);

        Console.WriteLine("Methods:");
        foreach (var m in t.GetMethods())
            Console.WriteLine(m.Name);

        Console.WriteLine("Fields:");
        foreach (var f in t.GetFields())
            Console.WriteLine(f.Name);
    }
}
