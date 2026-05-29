using System;
namespace Herencia;

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero("Thor", 5, 100, 20);
        Mago mago = new Mago("Merlin", 7, 80, 30);

        Console.WriteLine("=== GUERRERO ===");
        guerrero.MostrarInfo();
        guerrero.Atacar();

        Console.WriteLine();

        Console.WriteLine("=== MAGO ===");
        mago.MostrarInfo();
        mago.Atacar();
    }
}