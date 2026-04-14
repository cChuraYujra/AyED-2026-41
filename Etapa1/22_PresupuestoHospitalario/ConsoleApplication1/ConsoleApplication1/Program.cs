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
            Console.Write("Ingrese un pago anuel para el  Hospital : ");
            double Pago = double.Parse(Console.ReadLine());
            double Ginecología = (40 * Pago) / 100;
            double Traumatología = (30 * Pago) / 100;
            double Pediatría = (30 * Pago) / 100;
            Console.WriteLine("Ginecología recibe : " + Ginecología);
            Console.WriteLine("Traumatología recibe : " + Traumatología);
            Console.Write("Pediatría recibe : " + Pediatría);
            Console.ReadKey();
        }
    }
}
