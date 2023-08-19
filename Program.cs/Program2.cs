// See https://aka.ms/new-console-template for more information
using System;

namespace ArregloEjercicio2;

class Program
{
    static void Main()
    {
        
        string[] nombreCompleto = { "Brandon", "Emerson" };

        foreach (string valor in nombreCompleto)
        {
            Console.WriteLine(valor);
        }

        int longitudArreglo = nombreCompleto.Length;

        Console.WriteLine("Tamaño del arreglo: " + longitudArreglo);
        foreach (string valor in nombreCompleto)
        {
            Console.WriteLine("Valor: " + valor);
        }
    }
}
