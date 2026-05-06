using System;
using System.Threading.Tasks;

class Program
{
    static async Task Work()
    {
        await Task.Delay(2000);
        Console.WriteLine("Work Completed");
    }

    static async Task Main()
    {
        Console.WriteLine("Starting...");
        await Work();
        Console.WriteLine("Finished");
    }
}