using System;

class Program
{
    static void Main()
    {
        int[] n = new int[10], d = new int[10];
        int cant = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            n[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            bool existe = false;

            for (int j = 0; j < cant; j++)
                if (n[i] == d[j])
                {
                    existe = true;
                    break;
                }

            if (!existe)
                d[cant++] = n[i];
        }

        Console.WriteLine("\nVALORES DIFERENTES");
        for (int i = 0; i < cant; i++)
            Console.WriteLine(d[i]);
    }
}