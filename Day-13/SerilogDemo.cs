using System;
using Serilog;

class SerilogDemo
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("log.txt")
            .CreateLogger();

        Log.Information("Application Started");
        Log.Warning("This is a warning");
        Log.Error("This is an error");

        Console.WriteLine("Logs written to file");
    }
}