// See https://aka.ms/new-console-template for more information
using System;

namespace Ejercicio3;

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

        Console.WriteLine("\n ordenado:");
        foreach (string elemento in array)
        {
            Console.WriteLine(elemento);
        }
    }
}
