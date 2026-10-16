using System;

class Program
{
    static void Main()
    {
        int[] n = new int[10];
        int suma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            n[i] = int.Parse(Console.ReadLine());
            suma += n[i];
        }

        int mayor = n[0], menor = n[0];

        foreach (int x in n)
        {
            if (x > mayor) mayor = x;
            if (x < menor) menor = x;
        }

        Console.WriteLine("\n ELEMENTOS ");
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"Posición {i}: {n[i]}");

        Console.WriteLine($"\nSuma: {suma}");
        Console.WriteLine($"Promedio: {(double)suma / 10:F2}");
        Console.WriteLine($"Mayor: {mayor}");
        Console.WriteLine($"Menor: {menor}");
    }
}