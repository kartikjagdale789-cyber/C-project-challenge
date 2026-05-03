using System;

struct Student
{
    public int rollNo;
    public string name;

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}

class StructDemo
{
    static void Main()
    {
        Student s1;
        s1.rollNo = 101;
        s1.name = "Ajay";
        s1.Display();
    }
}