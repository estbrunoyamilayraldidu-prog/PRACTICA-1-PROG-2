using System;

class Program
{
    static void Main()
    {
        int cantidad = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                cantidad++;
            }
        }

        Console.WriteLine("\nCantidad de números pares: " + cantidad);
    }
}
