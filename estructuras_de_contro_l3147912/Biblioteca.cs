using System;
using System.Collections.Generic;

namespace estructuras_de_contro_l3147912
{
    internal class Biblioteca
    {
        // Lista de libros
        private List<Libro> libros = new List<Libro>();

        // Método para agregar un libro
        public void AgregarLibro()
        {
            Console.WriteLine("\n=== Agregar nuevo libro ===");
            Console.Write("Ingrese el título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese la editorial: ");
            string editorial = Console.ReadLine();

            Console.Write("Ingrese el año de publicación: ");
            int anio = int.Parse(Console.ReadLine());

            Libro nuevoLibro = new Libro(titulo, autor, editorial, anio);
            libros.Add(nuevoLibro);

            Console.WriteLine("\n📘 Libro agregado exitosamente.");
        }

        // Método para listar todos los libros
        public void ListarLibros()
        {
            Console.WriteLine("\n=== Lista de libros en la biblioteca ===");

            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
            }
            else
            {
                foreach (var libro in libros)
                {
                    libro.MostrarDetalles();
                }
            }
        }

        // Método para buscar un libro por su título
        public void BuscarLibro()
        {
            Console.Write("\nIngrese el título del libro que desea buscar: ");
            string tituloBuscado = Console.ReadLine();

            bool encontrado = false;

            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n📖 Libro encontrado:");
                    libro.MostrarDetalles();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\n❌ No se encontró ningún libro con ese título.");
            }
        }
    }
}
