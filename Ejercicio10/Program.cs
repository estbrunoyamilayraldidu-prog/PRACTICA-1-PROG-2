using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la operación (+, -, *, /): ");
        char operacion = char.Parse(Console.ReadLine());

        Console.WriteLine("\n RESULTADO ");

        switch (operacion)
        {
            case '+':
                Console.WriteLine("Resultado: " + (numero1 + numero2));
                break;

            case '-':
                Console.WriteLine("Resultado: " + (numero1 - numero2));
                break;

            case '*':
                Console.WriteLine("Resultado: " + (numero1 * numero2));
                break;

            case '/':
                if (numero2 != 0)
                {
                    Console.WriteLine("Resultado: " + (numero1 / numero2));
                }
                else
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                }
                break;

            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }
}
