using System;

class Employee
{
    public string Name;
    public double Salary;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.Name = "Ajay";
        e.Salary = 50000;

        e.Display();
    }
}
