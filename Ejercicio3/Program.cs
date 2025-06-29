using System;
using System.Collections.Generic;

namespace LoteriaPrimitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosGanadores = new List<int>();
            int cantidadNumeros = 6;

            Console.WriteLine("Introduce los 6 números ganadores de la lotería primitiva:");

            while (numerosGanadores.Count < cantidadNumeros)
            {
                Console.Write($"Número {numerosGanadores.Count + 1}: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    if (numero >= 1 && numero <= 49)
                    {
                        if (!numerosGanadores.Contains(numero))
                        {
                            numerosGanadores.Add(numero);
                        }
                        else
                        {
                            Console.WriteLine("Ese número ya fue introducido. Debe ser único.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número debe estar entre 1 y 49.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Introduce un número entero.");
                }
            }

            numerosGanadores.Sort(); // Ordenar de menor a mayor

            Console.WriteLine("\nNúmeros ganadores ordenados:");
            foreach (int numero in numerosGanadores)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\nPresiona una tecla para salir");
            Console.ReadKey();
        }
    }
}
