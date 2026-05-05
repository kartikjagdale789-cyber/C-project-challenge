using System;

class Student
{
    private int marks;

    public int Marks
    {
        get { return marks; }
        set { marks = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Marks = 90;

        Console.WriteLine("Marks: " + s.Marks);
    }
}