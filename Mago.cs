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

    public override void Atacar()
    {
        int daño = Mana * Nivel;
        Console.WriteLine($"{Nombre} lanza un hechizo y causa {daño} de daño.");
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Maná: {Mana}");
    }
}