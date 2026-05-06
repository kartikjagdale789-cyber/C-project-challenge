using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(1, 5, i =>
        {
            Console.WriteLine("Task " + i);
        });
    }
}