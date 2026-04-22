using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque 1 numero enteros : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("COloque otro numero entero : ");
            int num2 = int.Parse(Console.ReadLine());
            int Suma = num1 + num2;
            Console.WriteLine("El resultado es: " + Suma);
            Console.ReadLine();

        }
    }
}
