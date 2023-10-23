
using System;

public class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario Mensual: {Salario}, Salario Anual: {CalcularSalarioAnual()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Juan", 2000);
        Empleado empleado2 = new Empleado("Ana", 2500);

        empleado1.MostrarInformacion();
        empleado2.MostrarInformacion();

        Console.WriteLine("¡listo!");
    }
}
