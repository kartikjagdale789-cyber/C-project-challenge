using System;

class Student
{
    public string name;
    public int age;

    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class ClassObjectDemo
{
    static void Main()
    {
        Student s1 = new Student();

        s1.name = "Ajay";
        s1.age = 21;

        s1.display();
    }
}