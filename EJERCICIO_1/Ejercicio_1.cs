using System;

namespace EJERCICIO_1
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Ejercicio 1 ===");
            string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

