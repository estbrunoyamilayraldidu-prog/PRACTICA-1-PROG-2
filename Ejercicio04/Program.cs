using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine("\n CÍRCULO ");
        Console.WriteLine("Área: " + area.ToString("F2"));
        Console.WriteLine("Perímetro: " + perimetro.ToString("F2"));
    }
}