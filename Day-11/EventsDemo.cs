using System;

class Publisher
{
    public event EventHandler Notify;

    public void Process()
    {
        Console.WriteLine("Process Started");
        Notify?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Message(object sender, EventArgs e)
    {
        Console.WriteLine("Event Triggered!");
    }

    static void Main()
    {
        Publisher p = new Publisher();
        p.Notify += Message;
        p.Process();
    }
}