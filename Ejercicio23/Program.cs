using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de términos: ");
        int n = int.Parse(Console.ReadLine());

        long anterior = 0;
        long actual = 1;

        Console.WriteLine("\n===== FIBONACCI =====");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(anterior);

            if (i < n)
            {
                Console.Write(", ");
            }

            long siguiente = anterior + actual;
            anterior = actual;
            actual = siguiente;
        }

        Console.WriteLine();
    }
}