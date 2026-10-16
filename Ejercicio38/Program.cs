using System;

class Program
{
    static void Main()
    {
        int[,] m = new int[3, 3], t = new int[3, 3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
                t[j, i] = m[i, j];
            }

        Console.WriteLine("\nMATRIZ ORIGINAL");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }

        Console.WriteLine("\nMATRIZ TRANSPUESTA");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(t[i, j] + "\t");
            Console.WriteLine();
        }
    }
}