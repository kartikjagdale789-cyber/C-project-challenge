using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Ajay", "Amit", "Rahul", "Riya", "Anita" };

        var group = names.GroupBy(n => n[0]);

        foreach (var g in group)
        {
            Console.WriteLine("Group: " + g.Key);

            foreach (var name in g)
            {
                Console.WriteLine(name);
            }
        }
    }
}