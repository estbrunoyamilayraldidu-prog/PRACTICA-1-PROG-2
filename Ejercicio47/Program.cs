using System;

class CuentaBancaria
{
    public string NumeroCuenta, Titular;
    private double Saldo;

    public CuentaBancaria(string cuenta, string titular, double saldo)
    {
        NumeroCuenta = cuenta;
        Titular = titular;
        Saldo = saldo;
    }

    public void Depositar(double c)
    {
        if (c > 0)
        {
            Saldo += c;
            Console.WriteLine("Depósito realizado correctamente.");
        }
        else Console.WriteLine("La cantidad debe ser mayor que cero.");
    }

    public void Retirar(double c)
    {
        if (c <= 0)
            Console.WriteLine("La cantidad debe ser mayor que cero.");
        else if (c > Saldo)
            Console.WriteLine("Saldo insuficiente.");
        else
        {
            Saldo -= c;
            Console.WriteLine("Retiro realizado correctamente.");
        }
    }

    public void ConsultarSaldo() =>
        Console.WriteLine($"Saldo disponible: {Saldo:F2} Bs");
}

class Program
{
    static void Main()
    {
        CuentaBancaria c = new CuentaBancaria(
            "001-123456", "Bruno Ayraldi", 1000);

        Console.WriteLine($"Titular: {c.Titular}");
        Console.WriteLine($"Cuenta: {c.NumeroCuenta}");

        c.ConsultarSaldo();
        c.Depositar(500);
        c.ConsultarSaldo();
        c.Retirar(300);
        c.ConsultarSaldo();
        c.Retirar(2000);
        c.ConsultarSaldo();
    }
}