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
            Console.Write("¿Quieres terminar el programa? : ");
            string rta = Console.ReadLine();
            if(rta != "SI")
            {
                while (rta != "SI")
                {
                    Console.Write("¿Quieres terminar el programa? : ");
                    rta = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
