using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int baseNumero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente positivo: ");
        int exponente = int.Parse(Console.ReadLine());

        long resultado = 1;

        for (int i = 1; i <= exponente; i++)
        {
            resultado *= baseNumero;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}