using System;

class Program
{
    static void Main()
    {
        double[] n = new double[10];
        double suma = 0;
        int aprobados = 0, reprobados = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            n[i] = double.Parse(Console.ReadLine());
            suma += n[i];

            if (n[i] >= 51) aprobados++;
            else reprobados++;
        }

        double mayor = n[0], menor = n[0];

        for (int i = 1; i < 10; i++)
        {
            if (n[i] > mayor) mayor = n[i];
            if (n[i] < menor) menor = n[i];
        }

        Console.WriteLine("\nRESULTADOS");
        Console.WriteLine($"Promedio general: {suma / 10:F2}");
        Console.WriteLine($"Nota mayor: {mayor}");
        Console.WriteLine($"Nota menor: {menor}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
    }
}