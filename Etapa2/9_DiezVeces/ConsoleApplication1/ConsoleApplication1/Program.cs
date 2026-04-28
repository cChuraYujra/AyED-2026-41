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
            Console.Write("Ingrese una palabra : ");
            string world = Console.ReadLine();
            int contador = 0;
            while (contador < 10)
            {
                contador ++ ;
                Console.WriteLine(world);
            }
            Console.ReadKey();
        }
    }
}
