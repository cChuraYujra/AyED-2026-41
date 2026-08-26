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
            Console.Write("Ingrese un numero : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + " + " + b + " = " + Suma(a, b));
            Console.ReadKey();
        }
        static int Suma(int num, int num2)
        {
            return num + num2;
        }
    }
}
