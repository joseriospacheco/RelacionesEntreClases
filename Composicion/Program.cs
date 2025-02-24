namespace Composicion;
public class Pagina
{
    public int Numero { get; private set; }
    public string Contenido { get; private set; }

    public Pagina(int numero, string contenido)
    {
        Numero = numero;
        Contenido = contenido;
    }

    public void MostrarPagina()
    {
        Console.WriteLine($"Página {Numero}: {Contenido}");
    }
}

public class Libro
{
    public string Titulo { get; private set; }
    private List<Pagina> Paginas { get; set; } // Composición: el libro crea y posee las páginas

    public Libro(string titulo, int cantidadPaginas)
    {
        Titulo = titulo;
        Paginas = [];

        // El libro crea sus propias páginas
        for (int i = 1; i <= cantidadPaginas; i++)
        {
            Paginas.Add(new Pagina(i, $"Contenido de la página {i} del libro {titulo}"));
        }
    }

    public void MostrarLibro()
    {
        Console.WriteLine($"Libro: {Titulo}");
        Console.WriteLine("Páginas:");
        foreach (var pagina in Paginas)
        {
            pagina.MostrarPagina();
        }
    }
}

// Programa Principal
class Program
{
    static void Main()
    {
        // Crear un libro con 5 páginas
        Libro libro = new Libro("Programación en C#", 5);

        // Mostrar el contenido del libro y sus páginas
        libro.MostrarLibro();
    }
}