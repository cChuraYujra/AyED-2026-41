using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero : ");
            int numero = int.Parse(Console.ReadLine());
            int cuadrado = numero * numero;
            int cubo = numero * numero * numero;
            Console.WriteLine("EL cuadrado del numero es : " + cuadrado);
            Console.WriteLine("EL cubo del numero es : " + cubo);
            Console.ReadKey();<

        }
    }
}
