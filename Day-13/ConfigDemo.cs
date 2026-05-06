using System;
using Microsoft.Extensions.Configuration;
using System.IO;

class ConfigDemo
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        Console.WriteLine(config["AppName"]);
    }
}