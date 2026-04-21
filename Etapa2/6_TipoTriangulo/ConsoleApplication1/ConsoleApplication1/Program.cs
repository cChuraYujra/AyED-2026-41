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
            Console.WriteLine("Ingrese la longitud de 3 lados de un triángulo");
            Console.Write("Lado 1 : ");
            float lado1 = float.Parse(Console.ReadLine());
            Console.Write("Lado 2 : ");
            float lado2 = float.Parse(Console.ReadLine());
            Console.Write("Lado 3 : ");
            float lado3 = float.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es equilátero.");
            }
            if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado2 != lado1))
            {
                Console.WriteLine("Es isósceles.");
            }
            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("Es escaleno.");
            }
            Console.ReadKey();
        }
    }
}
