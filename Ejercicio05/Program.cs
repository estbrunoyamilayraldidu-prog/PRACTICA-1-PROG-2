using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (9.0 / 5.0) * celsius + 32;

        Console.WriteLine("\n CONVERSIÓN ");
        Console.WriteLine("Celsius: " + celsius.ToString("F2"));
        Console.WriteLine("Fahrenheit: " + fahrenheit.ToString("F2"));

        Console.Write("\nIngrese una temperatura en Fahrenheit: ");
        double fahrenheit2 = double.Parse(Console.ReadLine());

        double celsius2 = (5.0 / 9.0) * (fahrenheit2 - 32);

        Console.WriteLine("Celsius equivalente: " + celsius2.ToString("F2"));
    }
}