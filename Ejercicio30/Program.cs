using System;

class Program
{
    static void Main()
    {
        string contraseñaCorrecta = "123456";
        int intentos = 0;
        bool acceso = false;

        while (intentos < 3)
        {
            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();

            intentos++;

            if (contraseña == contraseñaCorrecta)
            {
                acceso = true;
                Console.WriteLine("Acceso permitido.");
                break;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
            }
        }

        if (!acceso)
        {
            Console.WriteLine("Acceso bloqueado después de tres intentos.");
        }
    }
}