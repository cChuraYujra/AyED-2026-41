using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MInutosHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad en minutos : ");
            double min = double.Parse(Console.ReadLine());
            double min_restantes = min % 60;
            double hs = min / 60;
            Console.Write("En total son : " + hs + "hs " + min_restantes + "min");
            Console.ReadKey();
        }
    }
}
