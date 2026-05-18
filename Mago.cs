using System;
namespace Herencia;

public class Mago : Personaje
{
    public int Mana { get; set; }

    public Mago(string nombre, int nivel, int vida, int mana)
        : base(nombre, nivel, vida)
    {
        Mana = mana;
    }

    public void LanzarHechizo()
    {
        int danio = Mana * Nivel;

        Console.WriteLine($"{Nombre} lanza un hechizo y causa {danio} puntos de daño mágico.");
    }

    public void RecuperarMana()
    {
        Console.WriteLine($"{Nombre} recupera energía mágica.");
    }
}