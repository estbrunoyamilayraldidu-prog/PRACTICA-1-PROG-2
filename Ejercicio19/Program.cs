using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n===== TABLA DEL " + numero + " =====");

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}