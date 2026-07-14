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
            int n;
            int m;
            int numeros;
            Random rand = new Random();   

            Console.Write("Ingrese cuantas filas : ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cunantas columnas : ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    Console.Write(matriz[i, j] + " ");            
                }
                Console.WriteLine();
            }
             Console.ReadLine();
        }
    }
}
