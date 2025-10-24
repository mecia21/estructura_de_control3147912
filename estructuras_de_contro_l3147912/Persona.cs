using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; } // "F" o "M"
        public string Telefono { get; set; }

        // Constructor
        public Persona(string nombre, int edad, string genero, string telefono)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Telefono = telefono;
        }

        // Método para imprimir los detalles de la persona
        public void ImprimirDetalles()
        {
            Console.WriteLine("\n--- Detalles de la Persona ---");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }

        // Método para calcular la edad en días
        public void CalcularEdadEnDias()
        {
            int edadEnDias = Edad * 365;
            Console.WriteLine($"\nLa edad de {Nombre} en días es: {edadEnDias} días.");
        }
    }
}
