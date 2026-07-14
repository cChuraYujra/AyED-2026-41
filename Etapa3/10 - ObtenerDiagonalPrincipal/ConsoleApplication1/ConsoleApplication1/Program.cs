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
            int contador = 0;
            Console.Write("Ingrese el tamaño de la Matriz : ");
            int tamaño = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamaño, tamaño];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = contador;
                    contador++;
                }
            }
        }
    }
}
