using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public List<decimal> Ventas { get; set; }
        public const decimal SUELDO_BASE = 500000m;

        public Empleado(string nombre)
        {
            Nombre = nombre;
            Ventas = new List<decimal>();
        }

        public void AgregarVenta(decimal valor)
        {
            if (valor > 0)
                Ventas.Add(valor);
        }

        public int ContarVentasMenoresIguales300()
        {
            return Ventas.FindAll(v => v <= 300000).Count;
        }

        public int ContarVentasEntre300y800()
        {
            return Ventas.FindAll(v => v > 300000 && v < 800000).Count;
        }

        public int ContarVentasMayoresIguales800()
        {
            return Ventas.FindAll(v => v >= 800000).Count;
        }

        public decimal CalcularTotalVentas()
        {
            decimal total = 0;
            foreach (var v in Ventas)
                total += v;
            return total;
        }

        public decimal CalcularBonificacion()
        {
            decimal total = CalcularTotalVentas();
            decimal porcentaje = 0;

            if (total >= 800000)
                porcentaje = 0.10m;
            else if (total >= 400001 && total <= 800000)
                porcentaje = 0.05m;
            else if (total >= 400000)
                porcentaje = 0.03m;

            return total * porcentaje;
        }

        public decimal CalcularPagoTotal()
        {
            return SUELDO_BASE + CalcularBonificacion();
        }

        public void ImprimirResumen()
        {
            Console.WriteLine($"\nEmpleado: {Nombre}");
            Console.WriteLine($"Ventas <= 300,000: {ContarVentasMenoresIguales300()}");
            Console.WriteLine($"Ventas entre 300,000 y 800,000: {ContarVentasEntre300y800()}");
            Console.WriteLine($"Ventas >= 800,000: {ContarVentasMayoresIguales800()}");
            Console.WriteLine($"Total Ventas: ${CalcularTotalVentas():N0}");
            Console.WriteLine($"Bonificación: ${CalcularBonificacion():N0}");
            Console.WriteLine($"Pago total (con sueldo): ${CalcularPagoTotal():N0}");
        }
    }
}
