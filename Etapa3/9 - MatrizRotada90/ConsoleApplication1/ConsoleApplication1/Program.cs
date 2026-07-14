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

            Random rand = new Random();

            Console.Write("Ingrese el tamaño de la matriz : ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[i, n - 1 - j];
                    matriz[i, n - 1 - j] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[i, n - 1 - j];
                    matriz[i, n - 1 - j] = temp;
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
