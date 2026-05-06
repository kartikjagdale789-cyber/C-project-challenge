using System;

class GenericClass<T>
{
    public T data;

    public void Show()
    {
        Console.WriteLine("Data: " + data);
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> obj = new GenericClass<int>();
        obj.data = 10;
        obj.Show();
    }
}