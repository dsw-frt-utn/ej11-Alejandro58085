using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        casoList.AgregarAlumnos(new Alumno(1, "Maria", 8.5));
        casoList.AgregarAlumnos(new Alumno(2, "Juan", 9.8));
        casoList.AgregarAlumnos(new Alumno(3, "Ernesto", 7.5));

        Console.WriteLine("---Lista de Alumnos---");
        casoList.MostrarAlumnos();

        Alumno? encontrado = casoList.BuscarAlumno("Maria");
        Console.WriteLine("\n---Buscar 'Maria'---");
        Console.WriteLine(encontrado);

        Alumno? noExiste = casoList.BuscarAlumno("Manuel");
        Console.WriteLine("\n---Buscar Manuel---");
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        casoList.EliminarAlumno(encontrado!);
        Console.WriteLine("\n=== Eliminar a María ===");
        casoList.MostrarAlumnos();

        casoList.EliminarAlumnoPosicion(0);
        Console.WriteLine("\n---Alumno de posicion 0 eliminado");
        casoList.MostrarAlumnos();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDic = new CasoDictionary();
        casoDic.AgregarAlumno(101, new Alumno(1, "Juan", 9.8));
        casoDic.AgregarAlumno(123, new Alumno(2, "Maria", 8.5));
        casoDic.AgregarAlumno(124, new Alumno(3, "Ernesto", 6.8));

        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in casoDic.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} → {par.Value}");
        }
        Alumno? encontrado = casoDic.BuscarAlumno(123);
        Console.WriteLine("\n--Buscar legajo 123---");
        Console.WriteLine(encontrado);

        Alumno? noExiste = casoDic.BuscarAlumno(999);
        Console.WriteLine("\n=== Buscar legajo 999 ===");
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        casoDic.EliminarAlumno(101);
        Console.WriteLine("\n---Se eliminó legajo 101---");
        foreach (var par in casoDic.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} → {par.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        foreach (var libro in Libro.CrearLista())
        {
            casoLinq.AgregarLibro(libro);
        }

        Console.WriteLine($"Primero:   {casoLinq.GetPrimero()}");
        Console.WriteLine($"Último:    {casoLinq.GetUltimo()}");
        Console.WriteLine($"Total:     {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio:  {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n--- Libros con Id > 15 ---");
        casoLinq.GetListById().ForEach(Console.WriteLine);

        Console.WriteLine("\n--- Títulos y precios ---");
        casoLinq.GetLibros().ForEach(Console.WriteLine);

        Console.WriteLine($"\nMayor precio:  {casoLinq.GetMayorPrecio()}");
        Console.WriteLine($"Menor precio:  {casoLinq.GetMenorPrecio()}");

        Console.WriteLine("\n--- Libros sobre el promedio ---");
        casoLinq.GetMayorPromedio().ForEach(Console.WriteLine);

        Console.WriteLine("\n--- Ordenados por título ---");
        casoLinq.GetOrdenadosPorTitulo().ForEach(Console.WriteLine);
    }
}
