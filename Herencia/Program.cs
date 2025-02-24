namespace Herencia;

using System;

// Clase base Persona
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }

    public virtual void RealizarActividad()
    {
        Console.WriteLine($"{Nombre} está realizando una actividad.");
    }
}

// Clase derivada Estudiante que hereda de Persona
public class Estudiante : Persona
{
    public string Carrera { get; set; }

    public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
    {
        Carrera = carrera;
    }

    public override void RealizarActividad()
    {
        Console.WriteLine($"{Nombre} está estudiando la carrera de {Carrera}.");
    }
}

// Clase derivada Docente que hereda de Persona
public class Docente : Persona
{
    public string Materia { get; set; }

    public Docente(string nombre, int edad, string materia) : base(nombre, edad)
    {
        Materia = materia;
    }

    public override void RealizarActividad()
    {
        Console.WriteLine($"{Nombre} está enseñando la materia de {Materia}.");
    }
}

// Programa Principal
class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Estudiante
        var estudiante = new Estudiante("Carlos", 20, "Ingeniería de Software");
        estudiante.Presentarse();
        estudiante.RealizarActividad();

        Console.WriteLine();

        // Crear un objeto de tipo Docente
        var docente = new Docente("María", 45, "Matemáticas");
        docente.Presentarse();
        docente.RealizarActividad();
    }
}
