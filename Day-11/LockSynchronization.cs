using System;
using System.Threading;

class Program
{
    static object lockObj = new object();

    static void Print()
    {
        lock (lockObj)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " : " + i);
                Thread.Sleep(500);
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Print);
        Thread t2 = new Thread(Print);

        t1.Name = "Thread1";
        t2.Name = "Thread2";

        t1.Start();
        t2.Start();
    }
}