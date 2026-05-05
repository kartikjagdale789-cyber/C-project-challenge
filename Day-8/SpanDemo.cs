
using System;

class SpanDemo
{
    static void Main()
    {
        int[] numbers = {10, 20, 30, 40, 50};

        Span<int> span = numbers.AsSpan(1,3);

        Console.WriteLine("Span Elements:");
        foreach(var num in span)
            Console.WriteLine(num);

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("ReadOnlySpan Elements:");
        foreach(var num in readOnlySpan)
            Console.WriteLine(num);
    }
}