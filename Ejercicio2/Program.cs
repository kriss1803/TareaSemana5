using System;
using System.Collections.Generic;

namespace AbecedarioFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el abecedario (A-Z)
            List<char> abecedario = new List<char>();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                abecedario.Add(letra);
            }

            // Eliminar letras en posiciones múltiplos de 3
            // Nota: índice base 1 para el usuario, pero base 0 en programación
            for (int i = abecedario.Count; i >= 1; i--)
            {
                if (i % 3 == 0)
                {
                    abecedario.RemoveAt(i - 1);
                }
            }

            // Mostrar resultado
            Console.WriteLine("Abecedario sin letras en posiciones múltiplos de 3:");
            Console.WriteLine(string.Join(", ", abecedario));

            Console.WriteLine("\nPresiona una tecla para salir");
            Console.ReadKey();
        }
    }
}
