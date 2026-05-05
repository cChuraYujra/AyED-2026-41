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
            Console.Write("Ingrese un valoe en metros : ");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            double milimetros = metros * 1000;
            Console.WriteLine("Centimetros : " + centimetros + "\nMilimetros : " + milimetros);
            Console.ReadKey();
        }
    }
}
