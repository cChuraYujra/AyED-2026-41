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
            Console.Write("Ingrese un numero positivo : ");
            int time = int.Parse(Console.ReadLine());
            int contador = 0;
            while (contador <= time)
            {
                Console.WriteLine(time);
                time -- ;
            }
            Console.ReadKey();
        }
    }
}
