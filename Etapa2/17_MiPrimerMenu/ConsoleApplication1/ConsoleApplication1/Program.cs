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
            int opc = 0;
            while (opc != 4)
            {
                Console.Write("Welcome to the Menu!\nChoose an option\n1. Escribir algo\n2. Hacer un calculo básico\n3. Hacer un saludo personal\n4. SALIR\nOpción : ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.Write("Error ingrese un numero del menú");
                        Console.Clear();
                        break;
                    case 1:
                        Console.Write("Dime lo que quieras escribir : ");
                        string palabra = Console.ReadLine();
                        Console.Write(palabra);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingrese un numero : ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro numero 2 : ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma da : " + (num1 + num2));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Dime tu\nNombre : ");
                        string nombre = Console.ReadLine();
                        Console.Write("Apellido : ");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Hola " + nombre + " " + apellido);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("See you together!!!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Error ingrese un numero del menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
