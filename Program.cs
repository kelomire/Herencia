using System;
namespace Herencia;

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero("Thor", 5, 100, 20);

        guerrero.MostrarInfo();
        guerrero.GolpearConEspada();
        guerrero.BloquearAtaque();

        Console.WriteLine();

        Mago mago = new Mago("Merlin", 7, 80, 30);

        mago.MostrarInfo();
        mago.LanzarHechizo();
        mago.RecuperarMana();
    }
}