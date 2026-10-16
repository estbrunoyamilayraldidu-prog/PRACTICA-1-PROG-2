using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n RESULTADO ");

        if (numero == 0)
        {
            Console.WriteLine("El número es CERO.");
        }
        else if (numero > 0)
        {
            Console.WriteLine("El número es POSITIVO.");
        }
        else
        {
            Console.WriteLine("El número es NEGATIVO.");
        }

        if (numero != 0)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es PAR.");
            }
            else
            {
                Console.WriteLine("El número es IMPAR.");
            }
        }
    }
}