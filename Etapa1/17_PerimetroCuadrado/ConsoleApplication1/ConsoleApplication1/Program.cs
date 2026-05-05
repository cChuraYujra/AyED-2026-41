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
            Console.Write("Ingrese el la longitud de un cuadrado : ");
            double longitud = double.Parse(Console.ReadLine());
            double perimetro = longitud * 4;
            double superficie = Math.Pow(longitud, 2);
            Console.WriteLine("Perimetro : " + perimetro);
            Console.WriteLine("Superficie : " + superficie);
            Console.ReadKey();
        
        }
    }
}
