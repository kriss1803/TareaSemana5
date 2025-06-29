using System;
using System.Collections.Generic;

namespace CursoAsignaturas
{
    // Clase que representa un curso con asignaturas
    public class Curso
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>
            {
                "Estructuras de Datos",
                "Programación Orientada a Objetos",
                "Administración de Sistemas Operativos",
                "Instalaciones Eléctricas y Cableado Estructurado",
                "Fundamentos de Sistemas Digitales"
            };
        }

        // Método para mostrar las asignaturas
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            Curso miCurso = new Curso();
            miCurso.MostrarAsignaturas();

            Console.WriteLine("\nPresiona una tecla para salir");
            Console.ReadKey();
        }
    }
}

