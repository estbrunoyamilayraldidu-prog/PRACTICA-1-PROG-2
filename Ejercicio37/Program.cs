using System;

class Program
{
    static void Main()
    {
        int[,] m = new int[3, 3];
        int suma = 0, dp = 0, ds = 0;

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("\nMATRIZ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(m[i, j] + "\t");
                suma += m[i, j];

                if (i == j) dp += m[i, j];
                if (i + j == 2) ds += m[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma total: {suma}");
        Console.WriteLine($"Diagonal principal: {dp}");
        Console.WriteLine($"Diagonal secundaria: {ds}");
    }
}