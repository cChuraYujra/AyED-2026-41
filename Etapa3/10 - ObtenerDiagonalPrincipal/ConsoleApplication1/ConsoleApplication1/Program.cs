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
            Random rand = new Random();
            int n = 0;
            Console.Write("Ingrese el tamaño de la matriz : ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[] vector = new int[n];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                vector[i] = matriz[i, i];
            }            

            foreach (int diagonal in vector)
            {
                Console.Write(diagonal + ", ");
            }
            Console.ReadKey();
        }
    }
}
