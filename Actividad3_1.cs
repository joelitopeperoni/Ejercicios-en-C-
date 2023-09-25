using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int opcion;
            try
            {
                do
                {
                    Console.WriteLine("Menú de opciones:");
                    Console.WriteLine("1. Sumar dos números.");
                    Console.WriteLine("2. Convertir de Celsius a Fahrenheit.");
                    Console.WriteLine("3. Calcular area de circulo");
                    Console.WriteLine("4. Dia de la semana");
                    Console.WriteLine("5. Año bisiesto");
                    Console.WriteLine("5. Ecuaciónes de segundo grado");
                    Console.WriteLine("0. Salir.");
                    Console.Write("Selecciona una opción (0-1): ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Introduce el primer número: ");
                            double numero1 = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el segundo número: ");
                            double numero2 = double.Parse(Console.ReadLine());

                            double resultado = numero1 + numero2;
                            Console.WriteLine($"La suma de {numero1} y {numero2} es igual a {resultado}");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("Ingrese la temperatura en grados Celsius: ");
                            double celsius = double.Parse(Console.ReadLine());

                            double fahrenheit = (9.0 / 5.0) * celsius + 32;
                            Console.WriteLine($"La temperatura en grados Fahrenheit es {fahrenheit}°F");
                            break;

                        case 3:
                            const double Pi = 3.1415;
                            Console.Write("Ingrese el radio del círculo: ");
                            double radio = double.Parse(Console.ReadLine());

                            double area = Pi * radio * radio;
                            Console.WriteLine($"El área del círculo con radio {radio} es {area}");
                            break;

                        case 4:
                            Console.Write("Ingrese el número del dia de la semana (1-7): ");
                            int posicionsemana = int.Parse(Console.ReadLine());
                            string dia(int numeroDia)
                            {
                                switch (numeroDia)
                                {
                                    case 1:
                                        return "Lunes";
                                    case 2:
                                        return "Martes";
                                    case 3:
                                        return "Miércoles";
                                    case 4:
                                        return "Jueves";
                                    case 5:
                                        return "Viernes";
                                    case 6:
                                        return "Sábado";
                                    case 7:
                                        return "Domingo";
                                    default:
                                        return "Número de día no válido";
                                }
                            }
                            string nombredia = dia(posicionsemana);
                            Console.WriteLine($"El día correspondiente a la posición {posicionsemana} es {nombredia}");
                            break;

                        case 5:
                            Console.Write("Ingresa un año: ");
                            int año = int.Parse(Console.ReadLine());

                            const int DivisiblePor4 = 4;
                            const int DivisiblePor100 = 100;
                            const int DivisiblePor400 = 400;

                            if ((año % DivisiblePor4 == 0 && año % DivisiblePor100 != 0) || (año % DivisiblePor400 == 0))
                            {
                                Console.WriteLine($"{año} es un año bisiesto.");
                            }
                            else
                            {
                                Console.WriteLine($"{año} no es un año bisiesto.");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Resolución de ecuaciones de segundo grado");

                            Console.Write("Introduce el valor de a: ");
                            double a = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el valor de b: ");
                            double b = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el valor de c: ");
                            double c = double.Parse(Console.ReadLine());

                            double discriminante = Math.Pow(b, 2) - 4 * a * c;

                            if (discriminante > 0)
                            {
                                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                                Console.WriteLine($"Las raíces son: x1 = {raiz1}, x2 = {raiz2}");
                            }
                            else if (discriminante == 0)
                            {
                                double raiz = -b / (2 * a);
                                Console.WriteLine($"La raíz doble es: x = {raiz}");
                            }
                            else
                            {
                                Console.WriteLine("La ecuación no tiene soluciones reales.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Saliendo del programa.");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                } while (opcion != 0);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
        }
    }
}

