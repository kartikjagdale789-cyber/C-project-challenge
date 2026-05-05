using System;

class MemoryManagementDemo
{
    static void Main()
    {
        Console.WriteLine("Memory Management Example");

        for(int i = 0; i < 5; i++)
        {
            object obj = new object();
            Console.WriteLine("Object created");
        }

        GC.Collect();

        Console.WriteLine("Garbage Collection called");
    }
}