using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Universidad
    {
        // Clase interna para representar un programa académico
        class Programa
        {
            public string Nombre { get; set; }
            public int Creditos { get; set; }
            public double Descuento { get; set; }

            public Programa(string nombre, int creditos, double descuento)
            {
                Nombre = nombre;
                Creditos = creditos;
                Descuento = descuento;
            }
        }

        // Clase interna para representar a un estudiante
        class Estudiante
        {
            public string Nombre { get; set; }
            public Programa Programa { get; set; }
            public string FormaPago { get; set; } // Efectivo o Línea

            public Estudiante(string nombre, Programa programa, string formaPago)
            {
                Nombre = nombre;
                Programa = programa;
                FormaPago = formaPago;
            }
        }

        // Constante: valor de cada crédito
        const double ValorCredito = 200000;

        // Lista de programas
        static List<Programa> programas = new List<Programa>()
        {
            new Programa("Ingeniería de Sistemas", 20, 0.18),
            new Programa("Psicología", 16, 0.12),
            new Programa("Economía", 18, 0.10),
            new Programa("Comunicación Social", 18, 0.05),
            new Programa("Administración de Empresas", 20, 0.15)
        };

        // Lista de estudiantes matriculados
        static List<Estudiante> estudiantes = new List<Estudiante>();

        // Método principal
        public static void Ejecutar()
        {
            Console.WriteLine("=== MATRÍCULA UNIVERSITARIA ===\n");

            Console.Write("Ingrese la cantidad de estudiantes a matricular: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\n--- Estudiante #{i + 1} ---");
                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                // Mostrar programas
                Console.WriteLine("\nProgramas académicos:");
                for (int j = 0; j < programas.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {programas[j].Nombre}");
                }

                Console.Write("Seleccione el número del programa: ");
                int opcion = int.Parse(Console.ReadLine()) - 1;

                Programa programaSeleccionado = programas[opcion];

                // Forma de pago
                Console.Write("Forma de pago (Efectivo / Linea): ");
                string formaPago = Console.ReadLine().Trim().ToLower();

                estudiantes.Add(new Estudiante(nombre, programaSeleccionado, formaPago));
            }

            // Calcular resultados
            CalcularResultados();
        }

        // Método para calcular los resultados finales
        static void CalcularResultados()
        {
            double totalSinDescuento = 0;
            double totalDescuentos = 0;
            int totalCreditos = 0;

            // Contadores por programa
            Dictionary<string, int> conteoPorPrograma = new Dictionary<string, int>();

            foreach (var p in programas)
                conteoPorPrograma[p.Nombre] = 0;

            foreach (var e in estudiantes)
            {
                double valorPrograma = e.Programa.Creditos * ValorCredito;
                double descuento = 0;

                if (e.FormaPago == "efectivo")
                    descuento = valorPrograma * e.Programa.Descuento;

                totalSinDescuento += valorPrograma;
                totalDescuentos += descuento;
                totalCreditos += e.Programa.Creditos;
                conteoPorPrograma[e.Programa.Nombre]++;
            }

            // Mostrar resultados
            Console.WriteLine("\n=== RESULTADOS FINALES ===");
            Console.WriteLine("a) Estudiantes por programa académico:");
            foreach (var kvp in conteoPorPrograma)
                Console.WriteLine($"   - {kvp.Key}: {kvp.Value} estudiante(s)");

            Console.WriteLine($"\nb) Total de créditos inscritos: {totalCreditos}");
            Console.WriteLine($"c) Valor total sin descuento: ${totalSinDescuento:N0}");
            Console.WriteLine($"d) Total de descuentos aplicados: ${totalDescuentos:N0}");
            Console.WriteLine($"e) Valor neto de inscripciones: ${(totalSinDescuento - totalDescuentos):N0}");
        }
    }
}
