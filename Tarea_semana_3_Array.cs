﻿using System;

public class Estudiante
{
    // Atributos
    public int ID;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    // Constructor
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        ID = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Método para mostrar datos
    public void MostrarDatos()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        foreach (string tel in Telefonos)
        {
            Console.WriteLine($" - {tel}");
        }
    }
}

// Clase principal
class Programa
{
    static void Main(string[] args)
    {
        // Crear un array con tres teléfonos
        string[] telefonos = { "123", "456", "789" };

        // Crear un estudiante
        Estudiante estudiante = new Estudiante(1, "Jhony", "Nieto", "Av.6 de Diciembre", telefonos);

        // Mostrar los datos
        estudiante.MostrarDatos();
    }
}

