using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.txt";

        // Write to file
        File.WriteAllText(path, "Hello, this is file handling in C#");

        // Read from file
        string content = File.ReadAllText(path);
        Console.WriteLine("File Content: " + content);
    }
}
