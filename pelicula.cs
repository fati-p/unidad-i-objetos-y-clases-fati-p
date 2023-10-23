using System;

public class Película
{
    public string Título { get; set; }
    public int AñoLanzamiento { get; set; }
    public int Calificación { get; set; }

    public Película(string título, int añoLanzamiento, int calificación)
    {
        Título = título;
        AñoLanzamiento = añoLanzamiento;
        Calificación = calificación;
    }

    public void MostrarInformación()
    {
        Console.WriteLine($"Título: {Titulo}, Año de Lanzamiento: {AñoLanzamiento}, Calificación: {Calificación}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Película película1 = new Película("El Padrino", 1972, 5);
        Película película2 = new Película("Pulp Fiction", 1994, 4);

        película1.MostrarInformación();
        película2.MostrarInformación();

        Console.WriteLine("¡Hola, mundo!");
    }
}

