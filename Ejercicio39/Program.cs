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
                C[i, j] = A[i, j] + B[i, j];
            }

        Console.WriteLine("\nMATRIZ A");
        Mostrar(A);

        Console.WriteLine("\nMATRIZ B");
        Mostrar(B);

        Console.WriteLine("\nA + B");
        Mostrar(C);
    }

    static void Mostrar(int[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }
    }
}