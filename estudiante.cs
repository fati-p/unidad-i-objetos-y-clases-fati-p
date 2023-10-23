
using System;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }

    public Estudiante(string nombre, int edad, string curso)
    {
        Nombre = nombre;
        Edad = edad;
        Curso = curso;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Curso: {Curso}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante1 = new Estudiante("Juan", 20, "Matemáticas");
        Estudiante estudiante2 = new Estudiante("Ana", 22, "Física");

        estudiante1.MostrarInformacion();
        estudiante2.MostrarInformacion();

        Console.WriteLine(datos tomados");
    }
}
