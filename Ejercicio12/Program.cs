using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el importe de la compra: ");
        double precio = double.Parse(Console.ReadLine());

        double porcentaje = 0;

        if (precio < 100)
            porcentaje = 0;
        else if (precio < 500)
            porcentaje = 0.05;
        else if (precio < 1000)
            porcentaje = 0.10;
        else
            porcentaje = 0.15;

        double descuento = precio * porcentaje;
        double precioFinal = precio - descuento;

        Console.WriteLine("\n COMPRA ");
        Console.WriteLine("Precio original: " + precio.ToString("F2") + " Bs");
        Console.WriteLine("Descuento: " + descuento.ToString("F2") + " Bs");
        Console.WriteLine("Precio final: " + precioFinal.ToString("F2") + " Bs");
    }
}