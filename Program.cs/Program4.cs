﻿// See https://aka.ms/new-console-template for more information
using System;

namespace ArrayEjercicio4;

class Program
{
    static void Main(string[] args)
    {
        string[] array = { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

        Console.WriteLine("posiciones inicializadas:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Posición {i}: {array[i]}");
        }

        Array.Sort(array);

        Console.WriteLine("\nordenado:");
        foreach (string elemento in array)
        {
            Console.WriteLine(elemento);
        }

        string[] palabrasBusqueda = { "Sol", "Dedo", "Casa" };
        foreach (string palabra in palabrasBusqueda)
        {
            int posicion = Array.BinarySearch(array, palabra);

            if (posicion >= 0)
            {
                Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no se encontró en el array.");
            }
        }
    }
}

