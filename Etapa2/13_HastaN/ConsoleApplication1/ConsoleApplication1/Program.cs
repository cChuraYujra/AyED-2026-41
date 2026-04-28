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
            Console.Write("Ingrese un numero : ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= numero)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
                else
                {
                    contador++;
                }
            }
            Console.ReadKey();
        }
    }
}
