using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de segundos: ");
        int totalSegundos = int.Parse(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        Console.WriteLine("\n CONVERSIÓN ");
        Console.WriteLine("Horas: " + horas);
        Console.WriteLine("Minutos: " + minutos);
        Console.WriteLine("Segundos: " + segundos);
    }
}
