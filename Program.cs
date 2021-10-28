using System;
using System.Collections.Generic;
using System.Threading;

namespace practica1_actividad1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroProductos;
            var random = new Random();
            int opcion = 0;
            int borrarId;
            int elementosBorrados = 0;

            Console.WriteLine("Ingresa la cantidad de productos que deseas\n");
            numeroProductos = Convert.ToInt32(Console.ReadLine());

            // Producto[] productos = new Producto[numeroProductos];
            List<Producto> productos = new List<Producto>();

            void retirarElemento(int Id)
            {
                var producto = productos.Find(producto => producto.Id == Id);
                productos.Remove(producto);
            }

           
            for(int i=1; i<=numeroProductos; i++)
            {
                productos.Add(new Producto(){
                    Id = i, Nombre = $"Producto {i}", Cantidad = random.Next(1,10), Precio =  random.Next(30, 100)
                });
            }

    
            
            while(opcion != 5)
            {

                System.Console.WriteLine("\nElige una opcion:\n1. Imprimir lista\n2. Eliminar un elemento por Id\n3. Mostrar cantidad de productos disponibles\n4. Mostrar cantidad de productos retirados\n5. Salir del programa");
                opcion = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(500);

                switch(opcion)
                {
                    case 1:
                        System.Console.WriteLine("\nOpcion 1 seleccionada");
                        foreach (Producto producto in productos)
                        {
                            System.Console.WriteLine($"\nId: {producto.Id}\nNombre: {producto.Nombre}\nCantidad: {producto.Cantidad}\nPrecio :{producto.Precio}\n");
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("\nOpcion 2 seleccionada");
                        System.Console.WriteLine("\nIngrese el Id del elemento que desea retirar de la lista\n");
                        borrarId = Convert.ToInt32(Console.ReadLine());
                        retirarElemento(borrarId);
                        Thread.Sleep(500);
                        System.Console.WriteLine($"\nProducto {borrarId} retirado de la lista.\n");
                        elementosBorrados ++;
                        break;
                    case 3:
                        System.Console.WriteLine("\nOpcion 3 seleccionada");
                        System.Console.WriteLine($"\nCantidad de productos disponibles: {productos.Count}\n");
                        Thread.Sleep(500);
                        break;
                    case 4:
                        System.Console.WriteLine("\nOpcion 4 seleccionada");
                        System.Console.WriteLine($"\nCantidad de productos retirados: {elementosBorrados}\n");
                        Thread.Sleep(500);
                        break;
                    case 5:
                        opcion = 5;
                        System.Environment.Exit(-1);
                        break;
                    default :
                        System.Console.WriteLine("\nOpcion invalida\n");
                        break;
                }
        
            }
            Console.ReadKey();
        }
    }
}
