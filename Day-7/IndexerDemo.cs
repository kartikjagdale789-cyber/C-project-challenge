using System;

class Student
{
    private string[] names = new string[3];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class IndexerDemo
{
    static void Main()
    {
        Student s = new Student();

        s[0] = "Ajay";
        s[1] = "Rahul";
        s[2] = "Sneha";

        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);
    }
}