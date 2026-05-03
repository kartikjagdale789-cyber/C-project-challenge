using System;

class RandomNumbers
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("How many random numbers? ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Random Numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rand.Next(1, 101)); // 1 to 100
        }
    }
}