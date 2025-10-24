using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class EmpleadoTikTok
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public EmpleadoTikTok(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

        // Calcula la edad del empleado
        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }

        // Verifica si el empleado cumple con las condiciones para la bonificación
        public bool EsElegibleBonificacion()
        {
            int edad = CalcularEdad();
            return edad >= 18 && edad < 50;
        }
    }
}
