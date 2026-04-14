using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Dimensi_onDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159265359;
            Console.Write("Agrege un valor al radio : ");
            double radio = double.Parse(Console.ReadLine());
            double Sup = 4 * pi * Math.Pow(radio, 2);
            double Vol = 4 / 3 * pi * Math.Pow(radio, 3);
            Console.WriteLine("La superficie de la esfera es de : " + Sup);
            Console.Write("El volumen de la esfera es de : " + Vol);
            Console.ReadKey();
        }
    }
}
