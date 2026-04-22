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
            int MonedaOro = 10;
            int MonedaPlata = 2;
            Console.Write("¿Cuántas Moneras de Oro obtuviste? : ");
            int MonedaO = int.Parse(Console.ReadLine());
            Console.Write("¿Cuántas Monedas de Plata obtuviste? : ");
            int MonedaPla = int.Parse(Console.ReadLine());
            int Puntos = (MonedaOro * MonedaO) + (MonedaPlata * MonedaPla);
            if (Puntos >= 50 && Puntos <= 99)
            {
                Console.WriteLine("Nivel Superado!");
            }
            else if (Puntos >= 100)
            {
                Console.WriteLine("Nivel completado con bonus!!!");
            }
            else
            {
                Console.WriteLine("Nivel insuficiente");
            }
            Console.WriteLine("Puntos : " + Puntos);
            Console.ReadKey();       
        }
    }
}
