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
            Console.Write("Ingrese una temperatura en Celcius : ");
            double temp = double.Parse(Console.ReadLine());

            if (temp <= 0)
            {
                Console.Write("Se congela.");
            }
            else if (temp >= 100)
            {
                Console.Write("Esa cosa está que arde.");
            }
            else if (temp >= 1 || temp <= 99)
            {
                Console.Write("Esta en estado liqueido.");
            }
            Console.ReadKey();
        }
    }
}
