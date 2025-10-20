using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////-------------ARRAY-------
            //int[] numeros = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Ingrese número " + (i + 1) + ":");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nNúmeros ingresados:");
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            //int suma = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    suma += numeros[i];
            //}

            //Console.WriteLine("La suma de la lista es: " + suma);

            ////Lista
            //List<int> numeros = new List<int>();
            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);
            //numeros.Add(40);

            //Console.WriteLine("Numeros en la lista:");
            //foreach (int item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            ////Acceder a un elemento por su índice
            //int primerNumero = numeros[1];
            //Console.WriteLine($"El segundo número en la lista es: {primerNumero}");

            ////Modificar un elemento por su índice
            //numeros[2] = 50;
            //Console.WriteLine($"Número Modificado: {numeros[2]}");

            ////Insertar un elemento en una posición específica
            //numeros.Insert(2, 15);
            //Console.WriteLine($"Número Modificado: {numeros[2]}");

            ////Eliminar un elemento por posición
            //numeros.RemoveAt(1); // elimina la posición 1

            ////Eliminar un elemento por su valor
            //numeros.Remove(10); // elimina el número 10





            //List<string> nombres = new List<string>();
            //List<double> precios = new List<double>();

            //Console.WriteLine("AGREGAR PRODUCTOS");

            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.Write($"Ingrese el nombre del producto {i}: ");
            //    string nombre = Console.ReadLine();
            //    nombres.Add(nombre);

            //    Console.Write($"Ingrese el precio del producto {i}: ");
            //    double precio = Convert.ToDouble(Console.ReadLine());
            //    precios.Add(precio);
            //}

            //Console.WriteLine("\nLISTA DE PRODUCTOS");
            //for (int i = 0; i < nombres.Count; i++)
            //{
            //    Console.WriteLine($"{nombres[i]} - ${precios[i]}");
            //}

            //Console.Write("\nProducto que desea cambiar: ");
            //string cambiar = Console.ReadLine();

            //int posicion = nombres.IndexOf(cambiar);
            //if (posicion != -1)
            //{
            //    Console.Write("Nuevo nombre: ");
            //    string nuevoNombre = Console.ReadLine();
            //    nombres[posicion] = nuevoNombre;

            //    Console.Write("Nuevo precio: ");
            //    double nuevoPrecio = Convert.ToDouble(Console.ReadLine());
            //    precios[posicion] = nuevoPrecio;

            //    Console.WriteLine("Producto actualizado.");
            //}
            //else
            //{
            //    Console.WriteLine("Producto no encontrado.");
            //}

            //Console.Write("\nProducto que desea eliminar: ");
            //string eliminar = Console.ReadLine();

            //int posEliminar = nombres.IndexOf(eliminar);
            //if (posEliminar != -1)
            //{
            //    nombres.RemoveAt(posEliminar);
            //    precios.RemoveAt(posEliminar);
            //    Console.WriteLine("Producto eliminado.");
            //}
            //else
            //{
            //    Console.WriteLine("Producto no encontrado.");
            //}

            //Console.WriteLine("\nLISTA FINAL DE PRODUCTOS");
            //for (int i = 0; i < nombres.Count; i++)
            //{
            //    Console.WriteLine($"{nombres[i]} - ${precios[i]}");
            //}

            //Console.WriteLine("\nPrograma terminado.");

            int[] numeros = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros ingresados:");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine("\nLa suma de la lista es: " + suma);
        }
    }
}