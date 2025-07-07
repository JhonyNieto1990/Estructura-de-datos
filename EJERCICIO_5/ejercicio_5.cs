using System;

namespace EJERCICIO_5
{
    public class Ejercicio5
    {
        public static void Ejecutar()
        {
            int[] numeros = new int[5];
            int suma = 0;

            Console.WriteLine("Ingrese 5 números:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            double promedio = (double)suma / numeros.Length;

            Console.WriteLine($"\nEl promedio es: {promedio:F2}");
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
