using System;

public class Mascota
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }

    public Mascota(string nombre, string tipo, int edad)
    {
        Nombre = nombre;
        Tipo = tipo;
        Edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Tipo: {Tipo}, Edad: {Edad}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mascota mascota1 = new Mascota("osito", "Perro", 5);
        Mascota mascota2 = new Mascota("pelusa", "Gato", 3);

        mascota1.MostrarInformacion();
        mascota2.MostrarInformacion();

        Console.WriteLine("informacion de las mascotas");
    }
}
