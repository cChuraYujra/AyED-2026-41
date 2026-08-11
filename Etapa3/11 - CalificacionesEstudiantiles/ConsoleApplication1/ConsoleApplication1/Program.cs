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

            Console.Write("Ingrese la cantidad de alumnos : ");
            n = int.Parse(Console.ReadLine());

            string[,] tabla = new string[n, 3];
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    for (int x = 0; x < tabla.GetLength(0); x++)
                    {
                        for (int y = 0; y < tabla.GetLength(1); y++)
                        {
                            Console.Write(tabla[x, y] + " ");
                        }
                        Console.WriteLine();
                    }
                    if (j == 0)
                    {
                        Console.Write("Nombre del alumno : ");
                    }
                    else if (j == 1)
                    {
                        Console.Write("Edad del alumno : ");
                    }
                    else
                    {
                        Console.Write("Nota del alumno : ");                        
                    }
                    tabla[i, j] = Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
