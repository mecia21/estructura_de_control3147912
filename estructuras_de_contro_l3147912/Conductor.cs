using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Conductor
    {
        public int AnioNacimiento { get; set; }
        public int Sexo { get; set; } // 1 = Femenino, 2 = Masculino
        public int RegistroCarro { get; set; } // 1 = Bogotá, 2 = Otras ciudades

        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - AnioNacimiento;
            return edad;
        }
    }
}
