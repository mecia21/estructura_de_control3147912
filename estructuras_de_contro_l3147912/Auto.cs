using System;

namespace estructuras_de_contro_l3147912
{
    internal class Auto
    {
        // Atributos
        private string marca;
        private string modelo;
        private int año;

        // Constructor
        public Auto(string marca, string modelo, int año)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }

        // Método para mostrar la información del auto
        public void mostrarInfo()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Año: {año}");
        }
    }
}
