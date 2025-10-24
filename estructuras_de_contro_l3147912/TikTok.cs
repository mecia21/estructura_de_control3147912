using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class TikTok
    {
        const int BONO = 150000;
        List<EmpleadoTikTok> empleados = new List<EmpleadoTikTok>();

        public void Ejecutar()
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmpleado #{i + 1}");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Fecha de nacimiento (yyyy-mm-dd): ");
                DateTime fecha = DateTime.Parse(Console.ReadLine());

                empleados.Add(new EmpleadoTikTok(nombre, fecha));
            }

            CalcularBonificaciones();
        }

        void CalcularBonificaciones()
        {
            double sumaEdades = 0;
            int totalBonos = 0;
            int[] empleadosPorMes = new int[12];

            foreach (var e in empleados)
            {
                int edad = e.CalcularEdad();
                sumaEdades += edad;

                if (e.EsElegibleBonificacion())
                {
                    empleadosPorMes[e.FechaNacimiento.Month - 1]++;
                    totalBonos += BONO;
                }
            }

            Console.WriteLine($"\nPromedio de edad: {sumaEdades / empleados.Count:F2} años");
            Console.WriteLine("\n--- Lista desglosada por meses ---");

            for (int i = 0; i < 12; i++)
            {
                if (empleadosPorMes[i] > 0)
                {
                    Console.WriteLine($"{new DateTime(1, i + 1, 1):MMMM}: {empleadosPorMes[i]} empleados, Dinero en Bonos: ${empleadosPorMes[i] * BONO:N0}");
                }
            }

            Console.WriteLine($"\nTotal de dinero en bonificaciones: ${totalBonos:N0}");
        }
    }
}