using System;

class Program
{
    static void Main()
    {
        int[] n = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            n[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9 - i; j++)
                if (n[j] > n[j + 1])
                {
                    int t = n[j];
                    n[j] = n[j + 1];
                    n[j + 1] = t;
                }

        Console.WriteLine("\nORDEN ASCENDENTE");
        for (int i = 0; i < 10; i++)
            Console.WriteLine(n[i]);
    }
}