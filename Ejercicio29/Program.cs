using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números desea ingresar?: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor que cero.");
            return;
        }

        double suma = 0;
        double mayor = double.MinValue;
        double menor = double.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            double numero = double.Parse(Console.ReadLine());

            suma += numero;

            if (numero > mayor)
                mayor = numero;

            if (numero < menor)
                menor = numero;
        }

        double promedio = suma / n;

        Console.WriteLine("\n RESULTADOS ");
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }
}