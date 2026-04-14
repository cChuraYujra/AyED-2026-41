using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte 1 numero : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte un segundo numero : ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Inserte un tercer numero : ");
            int numero3 = int.Parse(Console.ReadLine());
            int promedio = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine(promedio);
            Console.ReadKey();

        }
    }
}
