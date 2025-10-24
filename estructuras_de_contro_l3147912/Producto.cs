using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    public class Producto
    {
        public int ID { get; set; }
        
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
            
        public Producto(int id, string nombre, decimal precio)
        {
            ID = id;
            Nombre = nombre;
            Precio = precio;
        }

        public class ProductCrud
        {
            public List<Producto> productos = new List<Producto>();
            public int siguienteid = 1;
            
            public void AgregarProducto()
            {
                Console .WriteLine("Ingrese el nombre del producto:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto:");
                decimal precio = decimal.Parse(Console.ReadLine());

                Producto nuevoProducto = new Producto(siguienteid, nombre, precio);
                productos.Add(nuevoProducto);
                Console.WriteLine("Producto agregado con éxito.");
            }
            public void MostrarProductos()
            {
                Console.WriteLine("Lista de productos:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio}");
                }
            }

            public void actualizarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a actualizar:");
                int id = int.Parse(Console.ReadLine());
                var producto = productos.FirstOrDefault(p => p.ID == id);
                if (producto != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del producto:");
                    producto.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio del producto:");
                    producto.Precio = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Producto actualizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
          public void EliminarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a eliminar:");
                int id = int.Parse(Console.ReadLine());
                var producto = productos.FirstOrDefault(p => p.ID == id);
                if (producto != null)
                {
                    productos.Remove(producto);
                    Console.WriteLine("Producto eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
        }
    }
}
