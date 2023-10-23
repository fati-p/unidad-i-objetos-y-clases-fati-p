using System;

public class Libro
{
    public string Título { get; set; }
    public string Autor { get; set; }

    public Libro(string título, string autor)
    {
        Título = título;
        Autor = autor;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Título}, Autor: {Autor}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez");
        Libro libro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes");

        libro1.MostrarInformacion();
        libro2.MostrarInformacion();

        Console.WriteLine("¡Hola, mundo!");
    }
}
