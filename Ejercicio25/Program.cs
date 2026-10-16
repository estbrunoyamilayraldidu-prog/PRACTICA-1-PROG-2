using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        numero = Math.Abs(numero);

        int cantidad = 0;

        if (numero == 0)
        {
            cantidad = 1;
        }
        else
        {
            while (numero > 0)
            {
                numero /= 10;
                cantidad++;
            }
        }

        Console.WriteLine("El número tiene " + cantidad + " dígitos.");
    }
}