using System;

class Student
{
    public string name;

    public Student(string n)
    {
        name = n;
    }

    public void display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class ConstructorDemo
{
    static void Main()
    {
        Student s = new Student("Ajay");
        s.display();
    }
}