using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("NÚMEROS PRIMOS DEL 1 AL 1000");

        for (int n = 2; n <= 1000; n++)
        {
            bool primo = true;

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }

            if (primo) Console.Write(n + " ");
        }

        Console.WriteLine();
    }
}