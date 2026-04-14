using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese 3 letras: ");
            string letras = Console.ReadLine();
            Console.WriteLine("Las letra al reves son: " + letras[2] + letras[1] + letras[0]);
            Console.ReadKey();

        }
    }
}
