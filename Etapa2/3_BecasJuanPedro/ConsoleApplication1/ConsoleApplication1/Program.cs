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
            Console.Write("ingrese su edad : ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su salario mensual : ");
            int SalarioMensual = int.Parse(Console.ReadLine());

            if (edad > 19 && SalarioMensual <= 100000)
            {
                Console.WriteLine("Puede cobrar la beca.");
            }
            else if ((edad < 19 && SalarioMensual == 0) || (edad == 19 && SalarioMensual == 50000))
            {
                Console.WriteLine("puede cobrar la beca.");
            }
            else
            {
                Console.WriteLine("No puede cobrar la beca.");
            }
            Console.ReadKey();
        }
    }
}
