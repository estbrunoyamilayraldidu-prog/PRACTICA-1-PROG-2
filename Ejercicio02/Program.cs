using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre completo: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su ciudad: ");
        string ciudad = Console.ReadLine();

        Console.Write("Ingrese su carrera universitaria: ");
        string carrera = Console.ReadLine();

        Console.WriteLine("\n DATOS PERSONALES ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad + " años");
        Console.WriteLine("Ciudad: " + ciudad);
        Console.WriteLine("Carrera: " + carrera);
    }
}