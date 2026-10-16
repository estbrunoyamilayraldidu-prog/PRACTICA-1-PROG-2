using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo N: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma de 1 hasta " + n + " es: " + suma);
    }
}