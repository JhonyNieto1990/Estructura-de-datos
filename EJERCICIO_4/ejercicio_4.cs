using System;

namespace EJERCICIO_4
{
    public class Ejercicio4
    {
        public static void Ejecutar()
        {
            int a = 0, b = 1, c;

            Console.WriteLine("Serie Fibonacci (10 términos):");
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
