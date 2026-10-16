using System;
using System.Collections.Generic;

class Producto
{
    public int Codigo; public string Nombre, Categoria;
    public double Precio; public int Stock;

    public Producto(int c,string n,string cat,double p,int s)
    {
        Codigo=c; Nombre=n; Categoria=cat; Precio=p; Stock=s;
    }
}

class Cliente
{
    public int Codigo; public string Nombre,Apellido,Telefono;

    public Cliente(int c,string n,string a,string t)
    {
        Codigo=c; Nombre=n; Apellido=a; Telefono=t;
    }
}

class DetalleVenta
{
    public Producto Producto; public int Cantidad;
    public double Subtotal => Producto.Precio*Cantidad;

    public DetalleVenta(Producto p,int c)
    {
        Producto=p; Cantidad=c;
    }
}

class Venta
{
    public int Codigo; public Cliente Cliente;
    public DateTime Fecha=DateTime.Now;
    public List<DetalleVenta> Detalles=new List<DetalleVenta>();
    public double Descuento;

    public Venta(int c,Cliente x){Codigo=c;Cliente=x;}

    public double Subtotal()
    {
        double s=0;
        foreach(var d in Detalles)s+=d.Subtotal;
        return s;
    }

    public double Desc()=>Subtotal()*Descuento/100;
    public double Total()=>Subtotal()-Desc();
}

class Program
{
    static List<Producto> p=new List<Producto>();
    static List<Cliente> c=new List<Cliente>();
    static List<Venta> v=new List<Venta>();
    static int cv=1;

    static void Main()
    {
        int op;
        do
        {
            Console.WriteLine("\n=== SISTEMA DE VENTAS ===");
            Console.WriteLine("1.Producto\n2.Cliente\n3.Mostrar productos");
            Console.WriteLine("4.Buscar producto\n5.Registrar venta");
            Console.WriteLine("6.Mostrar ventas\n7.Reporte\n8.Salir");
            op=Int("Opción: ");

            switch(op)
            {
                case 1: Producto(); break;
                case 2: Cliente(); break;
                case 3: Productos(); break;
                case 4: Buscar(); break;
                case 5: Venta(); break;
                case 6: Ventas(); break;
                case 7: Reporte(); break;
                case 8: Console.WriteLine("Gracias por utilizar el sistema."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }while(op!=8);
    }

    static void Producto()
    {
        int x=Pos("Código: ");
        if(BP(x)!=null){Console.WriteLine("Código existente.");return;}

        string n=Texto("Nombre: "),cat=Texto("Categoría: ");
        double pr=PosD("Precio: ");
        int st=NoNeg("Stock: ");

        p.Add(new Producto(x,n,cat,pr,st));
        Console.WriteLine("Producto registrado.");
    }

    static void Cliente()
    {
        int x=Pos("Código: ");
        if(BC(x)!=null){Console.WriteLine("Código existente.");return;}

        string n=Texto("Nombre: "),a=Texto("Apellido: "),t=Texto("Teléfono: ");
        c.Add(new Cliente(x,n,a,t));
        Console.WriteLine("Cliente registrado.");
    }

    static void Productos()
    {
        if(p.Count==0){Console.WriteLine("No hay productos.");return;}

        foreach(var x in p)
            Console.WriteLine($"{x.Codigo} | {x.Nombre} | {x.Categoria} | {x.Precio:F2} Bs | Stock: {x.Stock}");
    }

    static void Buscar()
    {
        Producto x=BP(Pos("Código: "));
        if(x==null) Console.WriteLine("Producto no encontrado.");
        else Console.WriteLine($"{x.Codigo} | {x.Nombre} | {x.Categoria} | {x.Precio:F2} Bs | Stock: {x.Stock}");
    }

    static void Venta()
    {
        if(p.Count==0||c.Count==0)
        {
            Console.WriteLine("Debe registrar productos y clientes.");
            return;
        }

        Cliente cl=BC(Pos("Código cliente: "));
        if(cl==null){Console.WriteLine("Cliente inexistente.");return;}

        Venta x=new Venta(cv++,cl);
        string r;

        do
        {
            Productos();
            Producto pr=BP(Pos("Código producto: "));

            if(pr==null) Console.WriteLine("Producto inexistente.");
            else
            {
                int n=Pos("Cantidad: ");
                var d=BD(x,pr);

                if(d!=null)
                {
                    if(d.Cantidad+n>pr.Stock)
                        Console.WriteLine("Stock insuficiente.");
                    else d.Cantidad+=n;
                }
                else if(n>pr.Stock)
                    Console.WriteLine("Stock insuficiente.");
                else
                    x.Detalles.Add(new DetalleVenta(pr,n));
            }

            Console.Write("¿Otro producto? (s/n): ");
            r=Console.ReadLine().ToLower();
        }while(r=="s");

        if(x.Detalles.Count==0){Console.WriteLine("Venta vacía.");return;}

        x.Descuento=NoNegD("Descuento (%): ");
        if(x.Descuento>100)x.Descuento=0;

        foreach(var d in x.Detalles)d.Producto.Stock-=d.Cantidad;

        v.Add(x);
        Console.WriteLine("Venta registrada.");
        Comprobante(x);
    }

    static void Comprobante(Venta x)
    {
        Console.WriteLine("\n=== COMPROBANTE ===");
        Console.WriteLine($"Venta: {x.Codigo}\nFecha: {x.Fecha}");
        Console.WriteLine($"Cliente: {x.Cliente.Nombre} {x.Cliente.Apellido}");

        foreach(var d in x.Detalles)
            Console.WriteLine($"{d.Producto.Nombre} x {d.Cantidad} = {d.Subtotal:F2} Bs");

        Console.WriteLine($"Subtotal: {x.Subtotal():F2} Bs");
        Console.WriteLine($"Descuento: {x.Desc():F2} Bs");
        Console.WriteLine($"TOTAL: {x.Total():F2} Bs");
    }

    static void Ventas()
    {
        if(v.Count==0){Console.WriteLine("No hay ventas.");return;}

        foreach(var x in v)
            Console.WriteLine($"Venta {x.Codigo} | {x.Cliente.Nombre} {x.Cliente.Apellido} | Total: {x.Total():F2} Bs");
    }

    static void Reporte()
    {
        if(v.Count==0){Console.WriteLine("No hay ventas.");return;}

        double t=0;
        foreach(var x in v)t+=x.Total();

        Console.WriteLine($"Ventas: {v.Count}");
        Console.WriteLine($"Total: {t:F2} Bs");

        foreach(var x in v)
            Console.WriteLine($"Venta {x.Codigo}: {x.Total():F2} Bs");
    }

    static Producto BP(int x)
    {
        foreach(var a in p)if(a.Codigo==x)return a;
        return null;
    }

    static Cliente BC(int x)
    {
        foreach(var a in c)if(a.Codigo==x)return a;
        return null;
    }

    static DetalleVenta BD(Venta v,Producto p)
    {
        foreach(var d in v.Detalles)
            if(d.Producto.Codigo==p.Codigo)return d;
        return null;
    }

    static string Texto(string m)
    {
        string x;
        do
        {
            Console.Write(m); x=Console.ReadLine();
        }while(string.IsNullOrWhiteSpace(x));
        return x;
    }

    static int Int(string m)
    {
        int x;
        while(!int.TryParse(Console.ReadLine(),out x))
            Console.Write("Número válido: ");
        return x;
    }

    static int Pos(string m)
    {
        int x;
        do{x=Int(m);}while(x<=0);
        return x;
    }

    static int NoNeg(string m)
    {
        int x;
        do{x=Int(m);}while(x<0);
        return x;
    }

    static double PosD(string m)
    {
        double x;
        do
        {
            Console.Write(m);
        }while(!double.TryParse(Console.ReadLine(),out x)||x<=0);
        return x;
    }

    static double NoNegD(string m)
    {
        double x;
        do
        {
            Console.Write(m);
        }while(!double.TryParse(Console.ReadLine(),out x)||x<0);
        return x;
    }
}