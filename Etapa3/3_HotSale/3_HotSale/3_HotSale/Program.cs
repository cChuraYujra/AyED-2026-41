using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingrese la cantidad de productos vendidos : ");
            int TotalProductos = int.Parse(Console.ReadLine());
            double[] CantProductos = new double[TotalProductos];
            Console.WriteLine("\nIngrese el  valor de los productos : ");
            for (int i = 0; i < TotalProductos; i++)
            {
                Console.Write("Producto " + (i + 1) + " : ");
                CantProductos[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(CantProductos);

            Console.WriteLine("El precio más alto es de : " + CantProductos[TotalProductos - 1]);
            Console.WriteLine("El precio más bajo es de : " + CantProductos[0]);
            Console.WriteLine("Los productos de mayor a menor : ");
            Array.Reverse(CantProductos);
            foreach (double productos in CantProductos)
            {               
                Console.Write(productos + " , ");
            }
                     
            Console.ReadKey();
        }
    }
}