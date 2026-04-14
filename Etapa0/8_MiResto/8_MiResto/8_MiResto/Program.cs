using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque 1 un numero entero : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Coloque otro un numero entero : ");
            float num2 = float.Parse(Console.ReadLine());
            float resto = num1 % num2;
            Console.Write("El resto de los 2 numeros es : " + resto);
            Console.ReadKey();

        }
    }
}
