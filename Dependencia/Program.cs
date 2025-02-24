namespace Dependencia;

// Clase Documento
public class Documento
{
    public string Titulo { get; private set; }
    public string Contenido { get; private set; }

    public Documento(string titulo, string contenido)
    {
        Titulo = titulo;
        Contenido = contenido;
    }

    public void MostrarDocumento()
    {
        Console.WriteLine($"Documento: {Titulo}");
        Console.WriteLine($"Contenido: {Contenido}");
    }
}

// Clase Impresora (Dependencia)
public class Impresora
{
    public void Imprimir(Documento documento)
    {
        Console.WriteLine($"Imprimiendo documento: {documento.Titulo}");
        Console.WriteLine("=================================");
        Console.WriteLine(documento.Contenido);
        Console.WriteLine("=================================");
    }
}

// Programa Principal
class Program
{
    static void Main()
    {
        // Crear un documento
        Documento documento = new Documento("Informe de Ventas", "Este es el informe de ventas del mes...");

        // Crear la impresora
        Impresora impresora = new Impresora();

        // El documento usa la impresora temporalmente (Dependencia)
        impresora.Imprimir(documento);
    }
}