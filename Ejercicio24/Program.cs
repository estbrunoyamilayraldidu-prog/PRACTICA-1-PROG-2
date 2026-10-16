using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        int original = numero;
        int invertido = 0;

        numero = Math.Abs(numero);

        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero /= 10;
        }

        if (original < 0)
        {
            invertido *= -1;
        }

        Console.WriteLine("Número invertido: " + invertido);
    }
}