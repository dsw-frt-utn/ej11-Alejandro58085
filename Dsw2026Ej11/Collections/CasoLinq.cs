using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = new List<Libro>();
    public void agregarLibro(Libro libro)
    {
        libros.Add(libro);
    }
    public Libro GetPrimero()
    {
        return libros.First();
    }
    public Libro GetUltimo()
    {
        return libros.Last();
    }
    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }
    public decimal GetPromedioPrecios()
    {
        return libros.Average(promedio => promedio.Precio);
    }
    public List<Libro> GetListById()
    {
        return libros.Where(idMayor=> idMayor.Id> 15).ToList();
    }
    public List<string> Getibros()
    {
        return libros.Select(libro=>$"{libro.Titulo}-{libro.Precio:C}").ToList();
    }
    public Libro? GetMayorPrecio()
    {
        return libros.MaxBy(libro => libro.Precio);
    }
    public Libro? GetMenorPrecio()
    {
        return libros.MinBy(libro => libro.Precio);
    }
    public List<Libro> GetMayorProedio()
    {
        decimal promedio = libros.Average(l => l.Precio);
        return libros.Where(libro => libro.Precio > promedio).ToList();
    }
    public List<Libro> GetOrdenadosPorTitulo()
    {
        return libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
