using System;

class TorresDeHanoi
{
    static void MoverDiscos(int n, string origen, string destino, string auxiliar)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {origen} a {destino}");
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino);
            Console.WriteLine($"Mover disco {n} de {origen} a {destino}");
            MoverDiscos(n - 1, auxiliar, destino, origen);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int discos = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPasos para resolver las Torres de Hanoi:");
        MoverDiscos(discos, "Torre A", "Torre C", "Torre B");
    }
}

