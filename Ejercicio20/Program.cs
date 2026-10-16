using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(n + "! = " + factorial);
    }
}