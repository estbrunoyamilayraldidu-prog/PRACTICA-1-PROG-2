using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (numero1 + numero2));
                        break;

                    case 2:
                        Console.WriteLine("Resultado: " + (numero1 - numero2));
                        break;

                    case 3:
                        Console.WriteLine("Resultado: " + (numero1 * numero2));
                        break;

                    case 4:
                        if (numero2 != 0)
                            Console.WriteLine("Resultado: " + (numero1 / numero2));
                        else
                            Console.WriteLine("No se puede dividir entre cero.");
                        break;
                }
            }
            else if (opcion != 5)
            {
                Console.WriteLine("Opción no válida.");
            }

        } while (opcion != 5);

        Console.WriteLine("Programa finalizado.");
    }
}