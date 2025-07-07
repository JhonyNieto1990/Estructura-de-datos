// ListaEnlazada.cs
using System;

namespace ListasEnlazadas
{
    // Clase Nodo que representa cada elemento de la lista
    public class Nodo
    {
        public int Valor;
        public Nodo Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada con los métodos solicitados
    public class ListaEnlazada
    {
        public Nodo Cabeza;

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        // Método para insertar un valor al final
        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Cabeza == null)
                Cabeza = nuevo;
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        // Método 1: Contar elementos de la lista
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = Cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        // Método 2: Invertir la lista enlazada
        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = Cabeza;
            Nodo siguiente = null;
            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            Cabeza = anterior;
        }

        // Mostrar la lista
        public void Mostrar()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Insertar datos
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);
            lista.Insertar(40);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Contar elementos
            Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

            // Invertir la lista
            lista.Invertir();
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}

