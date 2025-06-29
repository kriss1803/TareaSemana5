using System;
using System.Collections.Generic;
using System.Linq;

namespace EstadisticaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números separados por comas:");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No se ha introducido ningún valor.");
                return;
            }

            string[] partes = input.Split(',');

            // Separar la cadena por comas y convertir a lista de números
            List<double> numeros = new List<double>();

            foreach (var parte in partes)
            {
                if (double.TryParse(parte.Trim(), out double num))
                {
                    numeros.Add(num);
                }
                else
                {
                    Console.WriteLine($"'{parte}' no es un número válido y será ignorado.");
                }
            }

            if (numeros.Count == 0)
            {
                Console.WriteLine("No se introdujeron números válidos.");
                return;
            }

            // Calcular media
            double media = numeros.Average();

            // Calcular desviación típica (muestral)
            double sumaCuadrados = numeros.Sum(n => Math.Pow(n - media, 2));
            double desviacionTipica = Math.Sqrt(sumaCuadrados / (numeros.Count - 1));

            Console.WriteLine($"\nMedia: {media:F2}");
            Console.WriteLine($"Desviación típica: {desviacionTipica:F2}");

            Console.WriteLine("\nPresiona una tecla para salir");
            Console.ReadKey();
        }
    }
}
