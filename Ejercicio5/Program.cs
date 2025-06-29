using System;
using System.Collections.Generic;

namespace NumerosInversos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la lista y llenarla con números del 1 al 10
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            // Invertir el orden
            numeros.Reverse();

            // Mostrar los números separados por comas
            Console.WriteLine("Números en orden inverso:");
            Console.WriteLine(string.Join(", ", numeros));

            Console.WriteLine("\nPresiona una tecla para salir");
            Console.ReadKey();
        }
    }
}
