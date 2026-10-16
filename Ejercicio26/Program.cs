using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("El número no es capicúa.");
            return;
        }

        int original = numero;
        int invertido = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero /= 10;
        }

        if (original == invertido)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
    }
}