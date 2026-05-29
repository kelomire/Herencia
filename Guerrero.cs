using System;
namespace Herencia;

public class Guerrero : Personaje
{
    public int Fuerza { get; set; }

    public Guerrero(string nombre, int nivel, int vida, int fuerza)
        : base(nombre, nivel, vida)
    {
        Fuerza = fuerza;
    }

    public override void Atacar()
    {
        int daño = Fuerza * Nivel;
        Console.WriteLine($"{Nombre} ataca con espada y causa {daño} de daño");
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Fuerza: {Fuerza}");
    }
}