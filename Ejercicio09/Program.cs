using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int numero3 = int.Parse(Console.ReadLine());

        int mayor = numero1;

        if (numero2 > mayor)
        {
            mayor = numero2;
        }

        if (numero3 > mayor)
        {
            mayor = numero3;
        }

        Console.WriteLine("\n RESULTADO ");
        Console.WriteLine("El número mayor es: " + mayor);
    }
}