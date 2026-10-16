using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la primera nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("\n RESULTADOS ");
        Console.WriteLine("Nota 1: " + nota1);
        Console.WriteLine("Nota 2: " + nota2);
        Console.WriteLine("Nota 3: " + nota3);
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));

        if (promedio >= 51)
        {
            Console.WriteLine("Estado: APROBADO");
        }
        else
        {
            Console.WriteLine("Estado: REPROBADO");
        }
    }
}