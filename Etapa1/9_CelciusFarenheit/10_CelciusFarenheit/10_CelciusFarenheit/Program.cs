using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor en grados centigrados para pasarlo a Klevins y a Farenheint : ");
            double celcius = double.Parse(Console.ReadLine());
            double kelvins = celcius + 273.15;
            double farenheint = celcius * 1.8 + 32;
            Console.WriteLine("Los grados en Kelvins son : " + kelvins);
            Console.Write("Los grados en Farenheint son : " + farenheint);
            Console.ReadLine();
        }
    }
}
