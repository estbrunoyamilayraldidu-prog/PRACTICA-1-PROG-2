using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra o frase: ");
        string texto = Console.ReadLine().ToLower().Replace(" ", "");

        bool palindromo = true;

        for (int i = 0; i < texto.Length / 2; i++)
        {
            if (texto[i] != texto[texto.Length - 1 - i])
            {
                palindromo = false;
                break;
            }
        }

        Console.WriteLine(palindromo
            ? "Es un palíndromo."
            : "No es un palíndromo.");
    }
}