using System;
namespace Herencia;

abstract public class Personaje
{
    public string Nombre { get; set; }
    public int Nivel { get; set; }
    public int Vida { get; set; }

    public Personaje(string nombre, int nivel, int vida)
    {
        Nombre = nombre;
        Nivel = nivel;
        Vida = vida;
    }

    public abstract void Atacar();

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Nivel: {Nivel}");
        Console.WriteLine($"Vida: {Vida}");
    }
}