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


using System;
using System.Collections.Generic;

// Clase que representa un paciente
public class Paciente
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }

    public Paciente(string nombre, string cedula, string telefono)
    {
        Nombre = nombre;
        Cedula = cedula;
        Telefono = telefono;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}, Cédula: {Cedula}, Teléfono: {Telefono}");
    }
}

// Clase que representa un turno
public class Turno
{
    public Paciente Paciente { get; set; }
    public DateTime FechaHora { get; set; }

    public Turno(Paciente paciente, DateTime fechaHora)
    {
        Paciente = paciente;
        FechaHora = fechaHora;
    }

    public void MostrarTurno()
    {
        Console.WriteLine($"Turno para {Paciente.Nombre} en {FechaHora}");
    }
}

// Clase que gestiona la agenda
public class Agenda
{
    private List<Turno> turnos = new List<Turno>();

    public void AgregarTurno(Turno turno)
    {
        turnos.Add(turno);
        Console.WriteLine("Turno agregado exitosamente.");
    }

    public void MostrarTurnos()
    {
        if (turnos.Count == 0)
        {
            Console.WriteLine("No hay turnos registrados.");
        }
        else
        {
            Console.WriteLine("Lista de turnos registrados:");
            foreach (var t in turnos)
            {
                t.MostrarTurno();
            }
        }
    }

    public void EliminarTurnoPorCedula(string cedula)
    {
        var turno = turnos.Find(t => t.Paciente.Cedula == cedula);
        if (turno != null)
        {
            turnos.Remove(turno);
            Console.WriteLine("Turno eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró un turno con esa cédula.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ AGENDA DE TURNOS ---");
            Console.WriteLine("1. Agregar turno");
            Console.WriteLine("2. Mostrar turnos");
            Console.WriteLine("3. Eliminar turno");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del paciente: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Cédula: ");
                    string cedula = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Fecha y hora del turno (yyyy-MM-dd HH:mm): ");
                    DateTime fechaHora;
                    if (DateTime.TryParse(Console.ReadLine(), out fechaHora))
                    {
                        Paciente paciente = new Paciente(nombre, cedula, telefono);
                        Turno turno = new Turno(paciente, fechaHora);
                        agenda.AgregarTurno(turno);
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha y hora inválido.");
                    }
                    break;
                case "2":
                    agenda.MostrarTurnos();
                    break;
                case "3":
                    Console.Write("Ingrese la cédula del paciente para eliminar el turno: ");
                    string cedulaEliminar = Console.ReadLine();
                    agenda.EliminarTurnoPorCedula(cedulaEliminar);
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}

