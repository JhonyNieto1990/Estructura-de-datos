using System;

namespace EJERCICIO_3
{
    public class Ejercicio3
    {
        public static void Ejecutar()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
