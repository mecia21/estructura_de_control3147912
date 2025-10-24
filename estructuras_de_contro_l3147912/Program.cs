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


            //Console.WriteLine("----- CÁLCULO DE PRÉSTAMO CON INTERÉS SIMPLE -----");

            //// Entrada de datos
            //Console.Write("Ingrese el monto del préstamo: ");
            //double prestamo = Convert.ToDouble(Console.ReadLine());

            //double tasaAnual = 0.05;  // 5%
            //double plazoAnios = 5;

            //// ⿡ Intereses en un año
            //double interesAnual = prestamo * tasaAnual * 1;

            //// ⿢ Intereses en el tercer trimestre del año (3 meses = 0.25 años)
            //double interesTercerTrimestre = prestamo * tasaAnual * 0.25;

            //// ⿣ Intereses en el primer mes (1/12 años)
            //double interesPrimerMes = prestamo * tasaAnual * (1.0 / 12.0);

            //// ⿤ Total a pagar al final del préstamo (capital + intereses)
            //double interesTotal5Anios = prestamo * tasaAnual * plazoAnios;
            //double totalPagar = prestamo + interesTotal5Anios;

            //// Salida de resultados
            //Console.WriteLine("\n===== RESULTADOS =====");
            //Console.WriteLine($"Intereses pagados en un año: ${interesAnual:N2}");
            //Console.WriteLine($"Intereses pagados en el tercer trimestre: ${interesTercerTrimestre:N2}");
            //Console.WriteLine($"Intereses pagados en el primer mes: ${interesPrimerMes:N2}");
            //Console.WriteLine($"Total a pagar (capital + intereses 5 años): ${totalPagar:N2}");

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();

            //// Creamos objetos de tipo Auto
            //Auto miAuto = new Auto("Toyota", "Corolla", 2020);
            //miAuto.mostrarInfo();

            //Auto bus = new Auto("Honda", "Civic", 2019);
            //bus.mostrarInfo();

            //Auto camion = new Auto("Ford", "F-150", 2021);
            //camion.mostrarInfo();

            //Console.ReadKey();


            //Console.WriteLine("=== Ingrese el nombre del estudiante ===\n");
            //string nombreEstudiante = Console.ReadLine();
            //Console .WriteLine("=== Ingrese la edad del estudiante ===\n");
            //int edad = int.Parse(Console.ReadLine());

            //Estudiante estudiante = new Estudiante(nombreEstudiante, edad);
            //estudiante.VerificarEdad();

            //Producto.ProductCrud crud = new Producto.ProductCrud();
            //bool salir = false;
            //while (!salir)
            //{
            //    Console.WriteLine("\n=== Menú de Gestión de Productos ===");
            //    Console.WriteLine("1. Agregar Producto");
            //    Console.WriteLine("2. Mostrar Productos");
            //    Console.WriteLine("3. Actualizar Producto");
            //    Console.WriteLine("4. Eliminar producto");
            //    Console.WriteLine("5. Salir");
            //    string opcion = Console.ReadLine();
            //    switch
            //        (opcion)
            //    {
            //        case "1":
            //            crud.AgregarProducto();
            //            break;
            //        case "2":
            //            crud.MostrarProductos();
            //            break;
            //        case "3":
            //            crud.actualizarProducto();
            //            break;
            //        case "4":
            //            crud.EliminarProducto();
            //            break;
            //        case "5":
            //            salir = true;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            //            break;
            //    }


            //Console.WriteLine("=== Programa Agenda ===");

            //// Solicitar los datos de la persona
            //Console.Write("Ingrese el nombre: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Ingrese la edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //Console.Write("Ingrese el género (F o M): ");
            //string genero = Console.ReadLine();

            //Console.Write("Ingrese el teléfono: ");
            //string telefono = Console.ReadLine();

            //// Crear objeto Persona
            //Persona persona = new Persona(nombre, edad, genero, telefono);

            //int opcion;
            //do
            //{
            //    Console.WriteLine("\n--- Menú ---");
            //    Console.WriteLine("1. Imprimir detalles de la persona");
            //    Console.WriteLine("2. Calcular edad en días");
            //    Console.WriteLine("3. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            persona.ImprimirDetalles();
            //            break;

            //        case 2:
            //            persona.CalcularEdadEnDias();
            //            break;

            //        case 3:
            //            Console.WriteLine("Saliendo del programa...");
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.");
            //            break;
            //    }

            //} while (opcion != 3);

            //Console.ReadKey();


            //Biblioteca biblioteca = new Biblioteca();
            //int opcion;

            //do
            //{
            //    Console.WriteLine("\n=== MENÚ DE LA BIBLIOTECA ===");
            //    Console.WriteLine("1. Agregar libro");
            //    Console.WriteLine("2. Listar libros");
            //    Console.WriteLine("3. Buscar libro por título");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");

            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            biblioteca.AgregarLibro();
            //            break;

            //        case 2:
            //            biblioteca.ListarLibros();
            //            break;

            //        case 3:
            //            biblioteca.BuscarLibro();
            //            break;

            //        case 4:
            //            Console.WriteLine("👋 Saliendo del programa...");
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.");
            //            break;
            //    }

            //} while (opcion != 4);

            //Console.ReadKey();


            //static void Main(string[] args)
            //{
            //    Universidad.Ejecutar();
            //}


            //Console.WriteLine("===== EMPRESA COMPUTRONIC =====");
            //Console.Write("Ingrese el número de empleados: ");
            //int cantidad = int.Parse(Console.ReadLine());

            //List<Empleado> empleados = new List<Empleado>();

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine($"\nEmpleado #{i + 1}");
            //    Console.Write("Nombre: ");
            //    string nombre = Console.ReadLine();

            //    Empleado emp = new Empleado(nombre);

            //    Console.Write("¿Cuántas ventas realizó hoy? ");
            //    int numVentas = int.Parse(Console.ReadLine());

            //    for (int j = 0; j < numVentas; j++)
            //    {
            //        Console.Write($"  Valor de la venta #{j + 1}: ");
            //        decimal valor = decimal.Parse(Console.ReadLine());
            //        emp.AgregarVenta(valor);
            //    }

            //    empleados.Add(emp);
            //}

            //Console.Clear();
            //Console.WriteLine("===== RESULTADOS =====");

            //foreach (Empleado e in empleados)
            //{
            //    e.ImprimirResumen();
            //}

            //Console.WriteLine("\nPresione una tecla para salir...");
            //Console.ReadKey();









            //List<Conductor> conductores = new List<Conductor>();

            //Console.Write("Ingrese la cantidad de conductores: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"\nConductor {i + 1}:");
            //    Console.Write("Año de nacimiento: ");
            //    int anio = int.Parse(Console.ReadLine());

            //    Console.Write("Sexo (1: Femenino, 2: Masculino): ");
            //    int sexo = int.Parse(Console.ReadLine());

            //    Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
            //    int registro = int.Parse(Console.ReadLine());

            //    conductores.Add(new Conductor
            //    {
            //        AnioNacimiento = anio,
            //        Sexo = sexo,
            //        RegistroCarro = registro
            //    });
            //}

            //int menores30 = 0;
            //int masculinos = 0;
            //int femeninos = 0;
            //int masculinos12a30 = 0;
            //int fueraBogota = 0;

            //foreach (var c in conductores)
            //{
            //    int edad = c.CalcularEdad();

            //    if (edad < 30) menores30++;
            //    if (c.Sexo == 1) femeninos++;
            //    if (c.Sexo == 2) masculinos++;
            //    if (c.Sexo == 2 && edad >= 12 && edad <= 30) masculinos12a30++;
            //    if (c.RegistroCarro == 2) fueraBogota++;
            //}

            //// Calcular porcentajes
            //double pMenores30 = (double)menores30 / n * 100;
            //double pFemeninos = (double)femeninos / n * 100;
            //double pMasculinos = (double)masculinos / n * 100;
            //double pMasculinos12a30 = (double)masculinos12a30 / n * 100;
            //double pFueraBogota = (double)fueraBogota / n * 100;

            //// Mostrar resultados
            //Console.WriteLine("\n--- Resultados Estadísticos ---");
            //Console.WriteLine($"Porcentaje de conductores menores de 30 años: {pMenores30:F2}%");
            //Console.WriteLine($"Porcentaje de conductores femeninos: {pFemeninos:F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos: {pMasculinos:F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos entre 12 y 30 años: {pMasculinos12a30:F2}%");
            //Console.WriteLine($"Porcentaje de conductores con carro registrado fuera de Bogotá: {pFueraBogota:F2}%");

            //Console.ReadKey();






            //TikTok app = new TikTok();
            //app.Ejecutar();

            //Console.ReadKey();



            CentralDistribucion app = new CentralDistribucion();
            app.Ejecutar();

            Console.ReadKey();

        }
    }
}
    



