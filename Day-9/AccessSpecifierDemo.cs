using System;

class Demo
{
    public int a = 10;
    private int b = 20;
    protected int c = 30;

    public void Show()
    {
        Console.WriteLine("Public: " + a);
        Console.WriteLine("Private: " + b);
        Console.WriteLine("Protected: " + c);
    }
}

class Program : Demo
{
    static void Main()
    {
        Program p = new Program();
        p.Show();
    }
}