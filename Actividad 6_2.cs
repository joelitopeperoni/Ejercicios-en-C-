using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<string> listacompra = new List<string>();

                while (true)
                {
                    Console.WriteLine("1. Añadir artículo");
                    Console.WriteLine("2. Eliminar artículo");
                    Console.WriteLine("3. Mostrar lista de la compra");
                    Console.WriteLine("4. Salir");

                    Console.Write("Selecciona una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Introduce un artículo: ");
                            string articulo = Console.ReadLine();
                            añadir(listacompra, articulo);
                            break;

                        case "2":
                            Console.Write("Introduce el artículo a eliminar: ");
                            string articuloaeliminar = Console.ReadLine();
                            bool existe = eliminar(listacompra, articuloaeliminar);
                            if (existe)
                            {
                                Console.WriteLine("Artículo eliminado");
                            }
                            else
                            {
                                Console.WriteLine("El artículo no está");
                            }
                            break;

                        case "3":
                            mostrar(listacompra);
                            break;

                        case "4":
                            Console.WriteLine("Saliendo del programa...");
                            return;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                            break;
                    }
                }
            }

            static void añadir(List<string> listacompra, string articulo)
            {
                listacompra.Add(articulo);
                Console.WriteLine("Artículo añadido");
            }

            static bool eliminar(List<string> listacompra, string articulo)
            {
                if (listacompra.Contains(articulo))
                {
                    listacompra.Remove(articulo);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static void mostrar(List<string> listacompra)
            {
                Console.WriteLine("Lista de la compra:");
                foreach (var articulo in listacompra)
                {
                    Console.WriteLine(articulo);
                }
            }
    }
}
