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

    public void GolpearConEspada()
    {
        int danio = Fuerza * Nivel;

        Console.WriteLine($"{Nombre} golpea con su espada y causa {danio} puntos de daño.");
    }

    public void BloquearAtaque()
    {
        int defensa = Fuerza + Nivel;

        Console.WriteLine($"{Nombre} bloquea el ataque con una defensa de {defensa} puntos.");
    }
}