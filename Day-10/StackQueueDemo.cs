using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Stack
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack Pop: " + stack.Pop());

        // Queue
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Queue Dequeue: " + queue.Dequeue());
    }
}