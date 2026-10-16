using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int secreto = random.Next(1, 101);
        int intento;
        int cantidadIntentos = 0;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        do
        {
            Console.Write("Ingrese su intento: ");
            intento = int.Parse(Console.ReadLine());

            cantidadIntentos++;

            if (intento < secreto)
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (intento > secreto)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine("Correcto.");
            }

        } while (intento != secreto);

        Console.WriteLine("Cantidad de intentos: " + cantidadIntentos);
    }
}