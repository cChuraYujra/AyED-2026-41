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
            Console.Write("Ingrese un año : ");
            int año = int.Parse(Console.ReadLine());
            if (año % 4 == 0 || año % 400 == 0)
            {
                Console.WriteLine("EL año es bisiesto.");
            }
            else
            {
                Console.WriteLine("EL año no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
