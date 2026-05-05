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

            while(opc != 5)
            {
                Console.WriteLine("|        MENU          |\n------------------------\n|1. Hola Mundo         |\n|2. Adios              |\n|3. Suma de 2 numeros  |\n|4. Usted seleccionó 4 |\n|5. SALIR              |\n------------------------");
                Console.Write("Opción : ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 0)
                {
                    Console.Clear();
                }
                else if (opc == 1)
                {
                    Console.WriteLine("Hola Mundo");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Adios");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Indique 2 numeros a sumar:");
                    Console.Write("Numero 1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Numero 2 : ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(num1 + num2);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(opc == 4)
                {
                    Console.WriteLine("Usted seleccionó 4");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(opc == 5)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("ERROR\nInserte algún numero mencionado en el menu");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Haz salido del programa...");
            Console.ReadKey();
        }
    }
}
