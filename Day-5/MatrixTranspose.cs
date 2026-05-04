using System;

class MatrixTranspose
{
    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };

        Console.WriteLine("Transpose Matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(A[j, i] + " ");
            Console.WriteLine();
        }
    }
}