namespace Implementacion;

using System;

// Definir la interfaz IVolar
public interface IVolar
{
    void Volar(); // Método que deben implementar las clases que pueden volar
}

// Clase base Animal
public abstract class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public abstract void HacerSonido(); // Método abstracto que debe ser implementado
}

// Clase Pájaro que hereda de Animal y además implementa IVolar
public class Pajaro : Animal, IVolar
{
    public Pajaro(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace: Pío Pío");
    }

    public void Volar()
    {
        Console.WriteLine($"{Nombre} está volando con sus alas.");
    }
}

// Clase Avión que NO hereda de Animal, pero sí implementa IVolar
public class Avion : IVolar
{
    public string Modelo { get; set; }

    public Avion(string modelo)
    {
        Modelo = modelo;
    }

    public void Volar()
    {
        Console.WriteLine($"El avión {Modelo} está volando en el cielo.");
    }
}

// Programa Principal
class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Pájaro
        Pajaro pajaro = new Pajaro("Gorrión");
        pajaro.HacerSonido();
        pajaro.Volar();

        Console.WriteLine();

        // Crear un objeto de tipo Avión
        Avion avion = new Avion("Boeing 747");
        avion.Volar();
    }
}
