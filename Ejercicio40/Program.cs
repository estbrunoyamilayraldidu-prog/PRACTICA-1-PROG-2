using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3], B = new int[3, 3], C = new int[3, 3];

        Console.WriteLine("MATRIZ A");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("\nMATRIZ B");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
                    C[i, j] += A[i, k] * B[k, j];

        Console.WriteLine("\nMATRIZ RESULTADO");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(C[i, j] + "\t");
            Console.WriteLine();
        }
    }
}