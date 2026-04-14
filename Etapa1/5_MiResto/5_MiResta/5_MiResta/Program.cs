using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiResta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque 1 numero entero : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.Write("Coloque otro numero entero : ");
            int Num2 = int.Parse(Console.ReadLine());
            int resta = Num1 - Num2;
            Console.Write("la resta de estos numero es : " + resta);
            Console.ReadKey();

        }
    }
}
