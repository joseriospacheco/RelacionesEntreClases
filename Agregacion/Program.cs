namespace Agregacion;

public class Modulo
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }

    public Modulo(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }

    public void MostrarModulo()
    {
        Console.WriteLine($"Módulo: {Nombre} (Código: {Codigo})");
    }
}

public class Curso
{
    public string Nombre { get; set; }
    public List<Modulo> Modulos { get; set; } // Relación de Agregación

    public Curso(string nombre)
    {
        Nombre = nombre;
        Modulos = [];
    }

    public void AgregarModulo(Modulo modulo)
    {
        Modulos.Add(modulo); // Se asocia un módulo, pero no se crea dentro del curso
    }

    public void MostrarCurso()
    {
        Console.WriteLine($"Curso: {Nombre}");
        Console.WriteLine("Módulos:");
        foreach (var modulo in Modulos)
        {
            modulo.MostrarModulo();
        }
    }
}

// Programa Principal
class Program
{
    static void Main()
    {
        // Creación de módulos independientes
        var modulo1 = new Modulo("M001", "Introducción a la Programación");
        var modulo2 = new Modulo("M002", "Programación Orientada a Objetos");
        var modulo3 = new Modulo("M003", "Bases de Datos");

        // Creación de un curso
        var curso = new Curso("Desarrollo de Software");

        // Se agregan módulos al curso (agregación, los módulos ya existen)
        curso.AgregarModulo(modulo1);
        curso.AgregarModulo(modulo2);
        curso.AgregarModulo(modulo3);

        // Mostrar información
        curso.MostrarCurso();
    }
}