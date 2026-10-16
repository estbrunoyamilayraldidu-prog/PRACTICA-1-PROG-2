using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 10 && numero <= 100)
        {
            Console.WriteLine("El número pertenece al rango [10, 100].");
        }
        else
        {
            Console.WriteLine("El número NO pertenece al rango [10, 100].");
        }
    }
}
