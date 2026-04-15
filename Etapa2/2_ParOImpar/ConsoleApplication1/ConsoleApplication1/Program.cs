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
            Console.Write("Coloque un numero aleatorio : ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.Write("El número es Par.");
            }
            else
            {
                Console.Write("El número es Impar.");
            }
            //Si se ingresa el numero 0, se le considerará numero par, porque el cero necesita cero veces 2 para que su resto sea 0, por ende se convertiria en número par. 
            Console.ReadKey();
        }
    }
}
