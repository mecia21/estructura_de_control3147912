using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class CamionAlcohol
    {
        public int CapacidadMaxima { get; set; }
        public int CargaActual { get; set; }

        public CamionAlcohol(int capacidadMaxima)
        {
            CapacidadMaxima = capacidadMaxima;
            CargaActual = 0;
        }

        // Método para intentar cargar un tanque
        public bool CargarTanque(int litrosTanque)
        {
            if (CargaActual + litrosTanque <= CapacidadMaxima)
            {
                CargaActual += litrosTanque;
                Console.WriteLine($"Tanque cargado con {litrosTanque} litros. Carga actual: {CargaActual}/{CapacidadMaxima}");
                return true;
            }
            else
            {
                Console.WriteLine($"⚠️ No se puede cargar {litrosTanque} litros. El camión está lleno ({CargaActual}/{CapacidadMaxima}).");
                return false;
            }
        }

        // Método para despachar el camión
        public void Despachar()
        {
            Console.WriteLine($"🚚 Camión despachado con {CargaActual} litros.\n");
        }
    }
}