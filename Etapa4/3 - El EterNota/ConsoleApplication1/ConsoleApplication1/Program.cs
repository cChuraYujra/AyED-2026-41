using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            //Matriz
            int[,] refugios = new int[20, 5];

            //Variables útiles de la matriz
            int id = 0;
            int capacidad = 1;
            int suministros = 2;
            int zona = 3;
            int ocupado = 4;

            int contador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        añadirRefugio(refugios, contador);
                        contador++;
                        break;
                    case 2:
                        // Lógica para mostrar todos los refugios
                        break;
                    case 3:
                        // Lógica para ocupar refugio
                        break;
                    case 4:
                        // Lógica para mostrar ocupados
                        break;
                    case 5:
                        // Lógica para refugio con más suministros
                        break;
                    case 6:
                        // Lógica para promedio por zona
                        break;
                    case 7:
                        // Lógica para filtrar por zona
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
        static void añadirRefugio(int [,] refugios, int contador)
        {

        }
    }
}
