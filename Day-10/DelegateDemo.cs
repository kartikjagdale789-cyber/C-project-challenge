using System;

delegate void ShowMessage(string msg);

class Program
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        ShowMessage sm = Display;
        sm("Hello from Delegate");
    }
}