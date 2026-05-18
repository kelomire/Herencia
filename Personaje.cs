using System;
namespace Herencia;

public class Personaje
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

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Nivel: {Nivel}");
        Console.WriteLine($"Vida: {Vida}");
    }
}