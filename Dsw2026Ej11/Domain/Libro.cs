namespace Dsw2026Ej11.Domain;

public class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public decimal Precio { get; set; }

    public Libro(int id, string titulo, decimal precio)
    {
        Id = id;
        Titulo = titulo;
        Precio = precio;
    }
    public override string ToString()
    {
        return $"{Id} - {Titulo} - Precio: {Precio:C}";
    }
    public static List<Libro> CrearLista()
    {
        return new List<Libro>
        {
            new Libro(1, "Clean Code", 45000),
            new Libro(2, "The Pragmatic Programmer", 52000),
            new Libro(3, "Design Patterns", 61000),
            new Libro(4, "Refactoring", 57000),
            new Libro(5, "Domain Driven Design", 65000),
            new Libro(6, "Código Sostenible", 39000),
            new Libro(7, "Introducción a C#", 28000),
            new Libro(8, "ASP.NET Core", 48000),
            new Libro(9, "Entity Framework", 43000),
            new Libro(10, "Arquitectura Limpia", 59000),
            new Libro(11, "Microservicios", 55000),
            new Libro(12, "Docker para Developers", 37000),
            new Libro(13, "Kubernetes Básico", 46000),
            new Libro(14, "Testing en .NET", 41000),
            new Libro(15, "Patrones de Integración", 53000),
            new Libro(16, "Fundamentos de SQL", 25000),
            new Libro(17, "LINQ Avanzado", 34000),
            new Libro(18, "Programación Orientada a Objetos", 30000),
            new Libro(19, "Java Moderno", 44000),
            new Libro(20, "Python Profesional", 47000),
            new Libro(21, "Git y GitHub", 26000),
            new Libro(22, "Scrum y Agile", 32000),
            new Libro(23, "Ingeniería de Software", 50000),
            new Libro(24, "Análisis de Sistemas", 36000),
            new Libro(25, "DevOps en la Práctica", 54000),
            new Libro(26, "Seguridad Informática", 58000),
            new Libro(27, "Redes y Comunicaciones", 35000),
            new Libro(28, "Machine Learning", 72000),
            new Libro(29, "Inteligencia Artificial", 78000),
            new Libro(30, "Cloud Computing", 62000)
        };
    }
}
