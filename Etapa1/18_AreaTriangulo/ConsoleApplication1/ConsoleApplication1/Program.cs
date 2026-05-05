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
            Console.Write("Valor de la base de un triangulo : ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("Valor de la altura de un triangulo : ");
            double Altura = double.Parse(Console.ReadLine());
            double area = (Base * Altura) / 2;
            Console.WriteLine("El area del triangulo es : " + area);
            Console.ReadKey(); 

        }
    }
}
