using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = true;

        if (numero < 2)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("El número es primo.");
        }
        else
        {
            Console.WriteLine("El número no es primo.");
        }
    }
}