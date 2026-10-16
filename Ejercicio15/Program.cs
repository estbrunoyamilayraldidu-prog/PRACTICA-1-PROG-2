using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 0)
        {
            Console.WriteLine("Error: la edad no puede ser negativa.");
        }
        else if (edad <= 5)
        {
            Console.WriteLine("Primera infancia.");
        }
        else if (edad <= 11)
        {
            Console.WriteLine("Infancia.");
        }
        else if (edad <= 17)
        {
            Console.WriteLine("Adolescencia.");
        }
        else if (edad <= 59)
        {
            Console.WriteLine("Adulto.");
        }
        else
        {
            Console.WriteLine("Adulto mayor.");
        }
    }
}
