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
            Console.Write("Su nombre : ");
            string nombre = Console.ReadLine();
            Console.Write("Su edad : ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Su ciudad : ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Su nombre es " + nombre + ", su edad " + edad + " y su ciudad " + ciudad);
            Console.ReadKey();
        }
    }
}
