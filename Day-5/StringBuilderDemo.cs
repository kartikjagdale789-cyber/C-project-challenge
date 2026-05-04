using System;
using System.Text;

class StringBuilderDemo
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" Ajay");
        sb.Insert(5, " C#");
        sb.Remove(0, 1);

        Console.WriteLine("Final String: " + sb);
    }
}