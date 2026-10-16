using System;
using System.Collections.Generic;

class Producto
{
    public int Codigo;
    public string Nombre;
    public double Precio;
    public int Cantidad;

    public double Total() => Precio * Cantidad;
}

class Program
{
    static List<Producto> p = new List<Producto>();

    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("\nINVENTARIO");
            Console.WriteLine("1. Registrar\n2. Mostrar\n3. Buscar\n4. Modificar cantidad\n5. Valor total\n6. Salir");
            Console.Write("Opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Registrar(); break;
                case 2: Mostrar(); break;
                case 3: Buscar(); break;
                case 4: Modificar(); break;
                case 5: TotalInventario(); break;
                case 6: Console.WriteLine("Programa finalizado."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (op != 6);
    }

    static void Registrar()
    {
        Producto x = new Producto();

        Console.Write("Código: "); x.Codigo = int.Parse(Console.ReadLine());
        Console.Write("Nombre: "); x.Nombre = Console.ReadLine();
        Console.Write("Precio: "); x.Precio = double.Parse(Console.ReadLine());
        Console.Write("Cantidad: "); x.Cantidad = int.Parse(Console.ReadLine());

        p.Add(x);
        Console.WriteLine("Producto registrado.");
    }

    static void Mostrar()
    {
        if (p.Count == 0)
        {
            Console.WriteLine("No hay productos.");
            return;
        }

        foreach (Producto x in p) Ver(x);
    }

    static void Buscar()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        foreach (Producto x in p)
            if (x.Codigo == codigo)
            {
                Ver(x);
                return;
            }

        Console.WriteLine("Producto no encontrado.");
    }

    static void Modificar()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        foreach (Producto x in p)
            if (x.Codigo == codigo)
            {
                Console.Write("Nueva cantidad: ");
                x.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad modificada.");
                return;
            }

        Console.WriteLine("Producto no encontrado.");
    }

    static void TotalInventario()
    {
        double total = 0;

        foreach (Producto x in p)
            total += x.Total();

        Console.WriteLine($"Valor total: {total:F2} Bs");
    }

    static void Ver(Producto x)
    {
        Console.WriteLine($"\nCódigo: {x.Codigo}");
        Console.WriteLine($"Nombre: {x.Nombre}");
        Console.WriteLine($"Precio: {x.Precio:F2} Bs");
        Console.WriteLine($"Cantidad: {x.Cantidad}");
        Console.WriteLine($"Valor: {x.Total():F2} Bs");
    }
}