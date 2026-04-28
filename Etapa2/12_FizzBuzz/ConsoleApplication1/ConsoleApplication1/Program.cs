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
            Console.Write("Ingrese un numero del 1 al 100 : ");
            int num = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= num)
            {
                if (contador % 5 == 0 && contador % 3 == 0)
                {
                    Console.WriteLine("fizz buzz");
                    contador++;
                }
                else if (contador % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    contador++;
                }
                else if (contador % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    contador++;
                }
                else
                {
                    Console.WriteLine(contador);
                    contador++;
                }
            }
            Console.ReadLine();

        }
    }
}
