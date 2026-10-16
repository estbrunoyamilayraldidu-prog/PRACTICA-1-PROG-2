using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string f = Console.ReadLine();

        int palabras = 0, vocales = 0, consonantes = 0, espacios = 0;
        bool palabra = false;

        foreach (char c in f)
        {
            if (char.IsWhiteSpace(c))
            {
                espacios++;
                palabra = false;
            }
            else
            {
                if (!palabra) { palabras++; palabra = true; }

                if (char.IsLetter(c))
                {
                    char x = char.ToLower(c);
                    if ("aeiou".Contains(x)) vocales++;
                    else consonantes++;
                }
            }
        }

        Console.WriteLine("\nRESULTADOS");
        Console.WriteLine($"Caracteres: {f.Length}");
        Console.WriteLine($"Palabras: {palabras}");
        Console.WriteLine($"Vocales: {vocales}");
        Console.WriteLine($"Consonantes: {consonantes}");
        Console.WriteLine($"Espacios: {espacios}");
    }
}