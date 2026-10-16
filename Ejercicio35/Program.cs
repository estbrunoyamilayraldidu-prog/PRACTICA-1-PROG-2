using System;

class Program
{
    static void Main()
    {
        int[] n = new int[20];
        bool[] c = new bool[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Número {i + 1}: ");
            n[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nFRECUENCIAS");

        for (int i = 0; i < 20; i++)
        {
            if (c[i]) continue;

            int f = 0;

            for (int j = 0; j < 20; j++)
                if (n[i] == n[j]) f++;

            Console.WriteLine($"Número {n[i]}: {f} vez/veces");

            for (int j = i; j < 20; j++)
                if (n[i] == n[j]) c[j] = true;
        }
    }
}