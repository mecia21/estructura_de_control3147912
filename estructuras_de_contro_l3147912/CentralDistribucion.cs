using System;

namespace estructuras_de_contro_l3147912
{
    internal class CentralDistribucion
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== CENTRAL DE DISTRIBUCIÓN DE ALCOHOL ===\n");
            const int TOTAL_CAMIONES = 20;

            for (int i = 1; i <= TOTAL_CAMIONES; i++)
            {
                Console.WriteLine($"\nCamión #{i}");
                Console.Write("Ingrese la capacidad del camión (entre 18000 y 28000 litros): ");
                int capacidad = int.Parse(Console.ReadLine());

                CamionAlcohol camion = new CamionAlcohol(capacidad);

                bool continuar = true;

                while (continuar)
                {
                    Console.Write("Ingrese litros del tanque (entre 3000 y 9000): ");
                    int tanque = int.Parse(Console.ReadLine());

                    if (!camion.CargarTanque(tanque))
                    {
                        camion.Despachar();
                        continuar = false;
                    }
                    else
                    {
                        Console.Write("¿Desea cargar otro tanque? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta != "s")
                        {
                            camion.Despachar();
                            continuar = false;
                        }
                    }
                }
            }

            Console.WriteLine("\n✅ Se han despachado los 20 camiones del día.");
        }
    }
}