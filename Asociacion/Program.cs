namespace Asociacion;

public class Direccion
{
    public string Calle { get; set; }
    public string Ciudad { get; set; }
    public string Pais { get; set; }

    public Direccion(string calle, string ciudad, string pais)
    {
        Calle = calle;
        Ciudad = ciudad;
        Pais = pais;
    }
}

public class Cliente
{
    public string Nombre { get; set; }
    public List<Direccion> Direcciones { get; set; } // Relación de asociación

    public Cliente(string nombre)
    {
        Nombre = nombre;
        Direcciones = new List<Direccion>(); // Inicializa la lista de direcciones
    }

    public void AsociarDireccion(Direccion direccion)
    {
        Direcciones.Add(direccion);
    }
}

// Uso en el programa
class Program
{
    static void Main()
    {
        var cliente = new Cliente("Juan Pérez");

        var direccion1 = new Direccion("Calle 123", "Bogotá", "Colombia");
        var direccion2 = new Direccion("Avenida Principal", "Medellín", "Colombia");

        cliente.AsociarDireccion(direccion1);
        cliente.AsociarDireccion(direccion2);

        Console.WriteLine($"Cliente: {cliente.Nombre}");
        Console.WriteLine("Direcciones:");
        foreach (var direccion in cliente.Direcciones)
        {
            Console.WriteLine($"- {direccion.Calle}, {direccion.Ciudad}, {direccion.Pais}");
        }
    }
}
