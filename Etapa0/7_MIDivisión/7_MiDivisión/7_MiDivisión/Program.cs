using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiDivisión
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque 1 numero entero : ");
            float Num1 = float.Parse(Console.ReadLine());
            Console.Write("Coloque otro numero entero : ");
            float Num2 = float.Parse(Console.ReadLine());
            float división = Num1 / Num2;
            Console.Write("La división de estos 2 numeros es : " + división);
            Console.ReadKey();

        }
    }
}
