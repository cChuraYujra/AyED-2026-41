using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiMultiplicación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque 1 numero entero : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.Write("Coloque otro numero entero : ");
            int Num2 = int.Parse(Console.ReadLine());
            int Por = Num1 * Num2;
            Console.Write("La multiplicación de los 2 numeros es : " + Por);
            Console.ReadKey();
        }
    }
}
