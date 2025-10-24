using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Libro
    {
        // Atributos o propiedades
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }

        // Constructor
        public Libro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AnioPublicacion = anioPublicacion;
        }

        // Método para imprimir detalles del libro
        public void MostrarDetalles()
        {
            Console.WriteLine($"\nTítulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Editorial: {Editorial}");
            Console.WriteLine($"Año de publicación: {AnioPublicacion}");
        }
    }
}
