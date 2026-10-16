using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n RESULTADOS ");
        Console.WriteLine("Suma: " + (numero1 + numero2));
        Console.WriteLine("Resta: " + (numero1 - numero2));
        Console.WriteLine("Multiplicación: " + (numero1 * numero2));

        if (numero2 != 0)
        {
            Console.WriteLine("División: " + ((double)numero1 / numero2));
        }
        else
        {
            Console.WriteLine("División: No se puede dividir entre cero.");
        }
    }
}