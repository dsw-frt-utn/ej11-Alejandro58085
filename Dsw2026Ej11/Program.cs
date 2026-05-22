using Dsw2026Ej11.Tests;

namespace Dsw2026Ej11;

internal class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            MostrarMenu();

            string? opcion= Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Ejemplos.EjemploList();
                    EsperarTecla();
                    break;
                case "2":
                    Console.Clear();
                    Ejemplos.EjemploDictionary();
                    EsperarTecla();
                    break;
                case "3":
                    Console.Clear();
                    Ejemplos.EjemploLinq();
                    EsperarTecla();
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("           MENÚ PRINCIPAL");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("1. Ejemplo List");
        Console.WriteLine("2. Ejemplo Dictionary");
        Console.WriteLine("3. Ejemplo LINQ");
        Console.WriteLine("4. Salir");
        Console.WriteLine("═══════════════════════════════════════");
        Console.Write("Seleccione una opción: ");
    }

    static void EsperarTecla()
    {
        Console.WriteLine("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }
}
