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
            int contador = 0;
            while (contador < edad)
            {
                contador++;
                Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}
