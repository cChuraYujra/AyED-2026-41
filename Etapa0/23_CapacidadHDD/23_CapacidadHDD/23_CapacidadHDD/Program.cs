using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            double bytes = 512;
            Console.Write("Ingrese una cantidad de Cilindros : ");
            double cilindros = double.Parse(Console.ReadLine());
            Console.Write("Ingrese una cantidad de Pistas por Cilindro : ");
            double PistaCilindro = double.Parse(Console.ReadLine());
            Console.Write("Ingrese una cantidad de Sectores por Pista : ");
            double SectoresPista = double.Parse(Console.ReadLine());
            double Kb = (512 * cilindros * PistaCilindro * SectoresPista) / 1000;
            double Mb = (512 * cilindros * PistaCilindro * SectoresPista) / 1000000;
            double Gb = (512 * cilindros * PistaCilindro * SectoresPista) / 1000000000;
            Console.WriteLine("Bytes a Kilobytes : " + Kb);
            Console.WriteLine("Bytes a Megabytes : " + Mb);
            Console.WriteLine("Bytes a Gigabytes : " + Gb);
            Console.ReadKey();
        }
    }
}
