using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Program
    {
        private const float V = 0.2f;

        static void Main(string[] args)// punto de partida
        {
            //tipos de datos


            //estructura de control
            //Console.WriteLine("Ingrese su edad: .");
            //int numero = int.Parse(Console.ReadLine()); //para leer la entrda de datos

            //Console.WriteLine($"su edad es: "+numero);
            //Console.WriteLine($"su edad es:  {numero}");


            //Console.WriteLine("ingrese 3 notas");
            //float n1 = int.Parse(Console.ReadLine());
            //float n2 = int.Parse(Console.ReadLine());
            //float n3 = int.Parse(Console.ReadLine());
            //if (n1 < 0 | n1 >5 | n2 < 0 | n2 > 5 | n3 < 0 | n3 > 5) ;
            //float promedioes = (n1 * 0.2f) + (n2 * 0.3f) + (n3 * 0.5f);
            //if(promedioes>=3)
            //{
            //    Console.WriteLine("aprobado");
            //}
            //else
            //{
            //    Console.WriteLine("desaprobado");
            //}

            //Console.WriteLine("ingrese el el precio del producto");
            //float product = int.Parse(Console.ReadLine());
            //if (product >= 100000)
            //{
            //    Console.WriteLine($"se le aplica el 20% de descuento entonces es"prce)
            //}

            ////Console.WriteLine("Ingrese el monto del préstamo: ");
            ////float monto = float.Parse(Console.ReadLine());

            ////float interesAnual = monto * 0.05f;  // 5% anual
            ////float interesTrimestre = interesAnual / 4;  // 4 trimestres por año
            ////float interesMes = interesAnual / 12;       // 12 meses por año

            ////float totalPagar = monto + (interesAnual * 5);  // total en 5 años

            ////Console.WriteLine("Interés pagado en un año: " + interesAnual);
            ////Console.WriteLine("Interés pagado en el tercer trimestre: " + interesTrimestre);
            ////Console.WriteLine("Interés pagado en el primer mes: " + interesMes);
            ////Console.WriteLine("Total a pagar incluyendo intereses: " + totalPagar);





            //Console.WriteLine("=== Colilla de Pago del Empleado ===\n");

            //// Entrada de datos
            //Console.Write("Ingrese el salario del empleado: ");
            //double salario = double.Parse(Console.ReadLine());

            //Console.Write("Ingrese el valor de ahorro mensual programado: ");
            //double ahorro = double.Parse(Console.ReadLine());

            //// Cálculos
            //double aporteSalud = salario * 0.125;   // 12.5%
            //double aportePension = salario * 0.16;  // 16%
            //double totalDeducciones = aporteSalud + aportePension + ahorro;
            //double totalRecibir = salario - totalDeducciones;

            //// Salida de datos
            //Console.WriteLine("\n--- Resultados ---");
            //Console.WriteLine($"Salario del empleado: {salario:C}");
            //Console.WriteLine($"Valor de ahorro mensual: {ahorro:C}");
            //Console.WriteLine($"Aporte a Salud (12.5%): {aporteSalud:C}");
            //Console.WriteLine($"Aporte a Pensión (16%): {aportePension:C}");
            //Console.WriteLine($"Total a recibir: {totalRecibir:C}");

            //Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            //Console.ReadKey();


            //Console.WriteLine("=== Cálculo de Cuotas de Matrícula ===\n");

            //// Entrada de datos
            //Console.Write("Ingrese el valor total de la matrícula: ");
            //double matricula = double.Parse(Console.ReadLine());

            //// Cálculos
            //double cuota1 = matricula * 0.40; // 40%
            //double cuota2 = matricula * 0.25; // 25%
            //double cuota3 = matricula * 0.20; // 20%
            //double cuota4 = matricula * 0.15; // 15%

            //// Salida de datos
            //Console.WriteLine("\n--- Cuotas a pagar ---");
            //Console.WriteLine($"Primera cuota (40%): {cuota1:C}");
            //Console.WriteLine($"Segunda cuota (25%): {cuota2:C}");
            //Console.WriteLine($"Tercera cuota (20%): {cuota3:C}");
            //Console.WriteLine($"Cuarta cuota (15%): {cuota4:C}");

            //Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            //Console.ReadKey();


            //Console.WriteLine("=== Datos del Aprendiz y Cálculo de Edad ===\n");

            //Console.Write("Ingrese el nombre del aprendiz: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Ingrese la dirección del aprendiz: ");
            //string direccion = Console.ReadLine();

            //Console.Write("Ingrese el año de nacimiento del aprendiz: ");
            //int anioNacimiento = int.Parse(Console.ReadLine());

            //int anioActual = DateTime.Now.Year;
            //int edad = anioActual - anioNacimiento;

            //Console.WriteLine("\n--- Información del Aprendiz ---");
            //Console.WriteLine($"Nombre: {nombre}");
            //Console.WriteLine($"Dirección: {direccion}");
            //Console.WriteLine($"Edad: {edad} años");

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();



            //Console.WriteLine("=== Cálculo de tiempo para llenar baldes ===\n");

            //double tiempoBalde1Litro = 1.5; // en horas

            //// Regla de tres
            //double tiempo3Litros = tiempoBalde1Litro * 3;
            //double tiempo5Litros = tiempoBalde1Litro * 5;

            //Console.WriteLine($"Tiempo para llenar 1 litro: {tiempoBalde1Litro} horas");
            //Console.WriteLine($"Tiempo para llenar 3 litros: {tiempo3Litros} horas");
            //Console.WriteLine($"Tiempo para llenar 5 litros: {tiempo5Litros} horas");

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();}



            //Console.WriteLine("=== Cálculo de tiempo para subir una montaña ===\n");

            //double alturaMontana = 7.0; // metros
            //double tiempoTotal = 5.0;  // horas

            //Console.Write("¿Cuántos metros desea subir el escalador?: ");
            //double metrosSubir = double.Parse(Console.ReadLine());

            //double tiempoEstimado = (metrosSubir * tiempoTotal) / alturaMontana;

            //Console.WriteLine($"\nTiempo estimado para subir {metrosSubir} metros: {tiempoEstimado} horas");

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();


            Console.WriteLine("----- CÁLCULO DE PRÉSTAMO CON INTERÉS SIMPLE -----");

            // Entrada de datos
            Console.Write("Ingrese el monto del préstamo: ");
            double prestamo = Convert.ToDouble(Console.ReadLine());

            double tasaAnual = 0.05;  // 5%
            double plazoAnios = 5;

            // ⿡ Intereses en un año
            double interesAnual = prestamo * tasaAnual * 1;

            // ⿢ Intereses en el tercer trimestre del año (3 meses = 0.25 años)
            double interesTercerTrimestre = prestamo * tasaAnual * 0.25;

            // ⿣ Intereses en el primer mes (1/12 años)
            double interesPrimerMes = prestamo * tasaAnual * (1.0 / 12.0);

            // ⿤ Total a pagar al final del préstamo (capital + intereses)
            double interesTotal5Anios = prestamo * tasaAnual * plazoAnios;
            double totalPagar = prestamo + interesTotal5Anios;

            // Salida de resultados
            Console.WriteLine("\n===== RESULTADOS =====");
            Console.WriteLine($"Intereses pagados en un año: ${interesAnual:N2}");
            Console.WriteLine($"Intereses pagados en el tercer trimestre: ${interesTercerTrimestre:N2}");
            Console.WriteLine($"Intereses pagados en el primer mes: ${interesPrimerMes:N2}");
            Console.WriteLine($"Total a pagar (capital + intereses 5 años): ${totalPagar:N2}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();



        }
    }
    }


