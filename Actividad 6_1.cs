using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main()
        {

            List<string> listacontactos = new List<string>();
           try {
                do
                {
                    Console.WriteLine("1. Agregar contacto");
                    Console.WriteLine("2. Eliminar contacto");
                    Console.WriteLine("3. Mostrar contactos");
                    Console.WriteLine("4. Salir");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Introduce el nombre del contacto: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Introduce el número de teléfono: ");
                            string telefono = Console.ReadLine();
                            añadir(listacontactos, nombre, telefono);
                            break;
                        case "2":
                            Console.Write("Introduce el nombre del contacto a eliminar: ");
                            string nombreeliminar = Console.ReadLine();

                            bool eliminado = eliminar(listacontactos, nombreeliminar);

                            if (eliminado)
                            {
                                Console.WriteLine("Contacto eliminado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el contacto con ese nombre.");
                            }
                            break;
                        case "3":
                            mostrar(listacontactos);
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
     
            static void añadir(List<string> contactos, string nombre, string telefono)
            {
                string nuevoContacto = $"{nombre}: {telefono}";
                contactos.Add(nuevoContacto);
            }

            static bool eliminar(List<string> contactos, string nombre)
            {

                string contactoeliminar = contactos.Find(c => c.StartsWith(nombre + ": "));

                if (contactoeliminar != null)
                {
                    contactos.Remove(contactoeliminar);
                    return true;
                }

                return false;
            }

            static void mostrar(List<string> contactos)
            {
                Console.WriteLine("Lista de contactos:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine(contacto);
                }
            }
        }

}

