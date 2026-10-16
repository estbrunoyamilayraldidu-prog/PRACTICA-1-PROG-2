using System;
using System.Collections.Generic;

class Estudiante
{
    public int Codigo;
    public string Nombre, Apellido, Carrera;
    public int Edad;
    public double NotaFinal;

    public bool Aprobado() => NotaFinal >= 51;
}

class Program
{
    static List<Estudiante> e = new List<Estudiante>();

    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("\nSISTEMA DE ESTUDIANTES");
            Console.WriteLine("1. Registrar\n2. Listar\n3. Buscar código\n4. Buscar nombre");
            Console.WriteLine("5. Aprobados\n6. Reprobados\n7. Promedio\n8. Salir");
            Console.Write("Opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Registrar(); break;
                case 2: Listar(); break;
                case 3: BuscarCodigo(); break;
                case 4: BuscarNombre(); break;
                case 5: Filtrar(true); break;
                case 6: Filtrar(false); break;
                case 7: Promedio(); break;
                case 8: Console.WriteLine("Programa finalizado."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (op != 8);
    }

    static void Registrar()
    {
        Estudiante x = new Estudiante();

        Console.Write("Código: "); x.Codigo = int.Parse(Console.ReadLine());
        Console.Write("Nombre: "); x.Nombre = Console.ReadLine();
        Console.Write("Apellido: "); x.Apellido = Console.ReadLine();
        Console.Write("Edad: "); x.Edad = int.Parse(Console.ReadLine());
        Console.Write("Carrera: "); x.Carrera = Console.ReadLine();
        Console.Write("Nota final: "); x.NotaFinal = double.Parse(Console.ReadLine());

        e.Add(x);
        Console.WriteLine("Estudiante registrado.");
    }

    static void Listar()
    {
        if (e.Count == 0)
        {
            Console.WriteLine("No hay estudiantes.");
            return;
        }

        foreach (Estudiante x in e) Mostrar(x);
    }

    static void BuscarCodigo()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        foreach (Estudiante x in e)
            if (x.Codigo == codigo)
            {
                Mostrar(x);
                return;
            }

        Console.WriteLine("Estudiante no encontrado.");
    }

    static void BuscarNombre()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        bool encontrado = false;

        foreach (Estudiante x in e)
            if (x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                Mostrar(x);
                encontrado = true;
            }

        if (!encontrado) Console.WriteLine("Estudiante no encontrado.");
    }

    static void Filtrar(bool aprobado)
    {
        Console.WriteLine(aprobado ? "\nAPROBADOS" : "\nREPROBADOS");

        foreach (Estudiante x in e)
            if (x.Aprobado() == aprobado) Mostrar(x);
    }

    static void Promedio()
    {
        if (e.Count == 0)
        {
            Console.WriteLine("No hay estudiantes.");
            return;
        }

        double suma = 0;
        foreach (Estudiante x in e) suma += x.NotaFinal;

        Console.WriteLine($"Promedio general: {suma / e.Count:F2}");
    }

    static void Mostrar(Estudiante x)
    {
        Console.WriteLine($"\nCódigo: {x.Codigo}");
        Console.WriteLine($"Nombre: {x.Nombre}");
        Console.WriteLine($"Apellido: {x.Apellido}");
        Console.WriteLine($"Edad: {x.Edad}");
        Console.WriteLine($"Carrera: {x.Carrera}");
        Console.WriteLine($"Nota: {x.NotaFinal}");
        Console.WriteLine($"Estado: {(x.Aprobado() ? "APROBADO" : "REPROBADO")}");
    }
}