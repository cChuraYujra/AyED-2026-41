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
            Console.Write("Ingrese su edad : ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
            Console.ReadKey();
        }
    }
}
