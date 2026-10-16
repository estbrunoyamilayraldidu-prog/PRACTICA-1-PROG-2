using System;

class Program
{
    static void Main()
    {
        double[] n = new double[5];

        for (int i = 0; i < 5; i++)
        {
            do
            {
                Console.Write($"Nota del estudiante {i + 1}: ");
                n[i] = double.Parse(Console.ReadLine());

                if (n[i] < 0 || n[i] > 100)
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");

            } while (n[i] < 0 || n[i] > 100);
        }

        Console.WriteLine("\nNOTAS");

        for (int i = 0; i < 5; i++)
            Console.WriteLine($"Estudiante {i + 1}: {n[i]}");
    }
}