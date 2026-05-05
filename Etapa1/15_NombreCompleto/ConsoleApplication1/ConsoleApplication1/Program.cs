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
            Console.Write("Nombre : ");
            string Nombre = Console.ReadLine();
            Console.Write("Apellido : ");
            string apellido = Console.ReadLine();
            Console.WriteLine(Nombre +(" ") + apellido);
            Console.ReadKey();
        }
    }
}
