using System;

class Program
{
    static void Main()
    {
        Console.Write("Primer número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Operación (+, -, *, /, ^): ");
        char op = char.Parse(Console.ReadLine());

        double r;

        switch (op)
        {
            case '+': r = a + b; break;
            case '-': r = a - b; break;
            case '*': r = a * b; break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return;
                }
                r = a / b;
                break;

            case '^':
                r = Math.Pow(a, (int)b);
                break;

            default:
                Console.WriteLine("Operación no válida.");
                return;
        }

        Console.WriteLine($"Resultado: {r}");
    }
}