using System;

class Program
{
    delegate void ShowMessage(string msg);

    static void Main()
    {
        ShowMessage message = delegate (string msg)
        {
            Console.WriteLine(msg);
        };

        message("Hello from Anonymous Method");
    }
}