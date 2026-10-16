using System;

class Estudiante
{
    public string Nombre, Apellido, Carrera;
    public int Edad;
    public double NotaFinal;

    public Estudiante(string n, string a, int e, string c, double nota)
    {
        Nombre = n; Apellido = a; Edad = e; Carrera = c; NotaFinal = nota;
    }

    public bool EstaAprobado() => NotaFinal >= 51;
}

class Program
{
    static void Main()
    {
        Estudiante[] estudiantes =
        {
            new Estudiante("Juan", "Perez", 20, "Ingeniería de Sistemas", 75),
            new Estudiante("Maria", "Lopez", 19, "Ingeniería de Sistemas", 45),
            new Estudiante("Carlos", "Gomez", 21, "Ingeniería de Sistemas", 88)
        };

        foreach (Estudiante e in estudiantes)
        {
            Console.WriteLine("\nESTUDIANTE");
            Console.WriteLine($"Nombre: {e.Nombre}");
            Console.WriteLine($"Apellido: {e.Apellido}");
            Console.WriteLine($"Edad: {e.Edad}");
            Console.WriteLine($"Carrera: {e.Carrera}");
            Console.WriteLine($"Nota final: {e.NotaFinal}");
            Console.WriteLine($"Estado: {(e.EstaAprobado() ? "APROBADO" : "REPROBADO")}");
        }
    }
}