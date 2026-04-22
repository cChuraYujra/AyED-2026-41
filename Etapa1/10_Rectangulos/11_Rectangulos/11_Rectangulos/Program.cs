using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Rectangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque un calor al eje X : ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Coloque un calor al eje Y : ");
            double Y = double.Parse(Console.ReadLine());
            double perimetro = X * 2 + Y * 2;
            double area = X * Y;
            double diagonal = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            Console.WriteLine("El Perimetro del rectangulo es de : " + perimetro);
            Console.WriteLine("El Area del rectangulo es de : " + area);
            Console.Write("La diagonal del rectangulo es de : " + diagonal);
            Console.ReadKey();
        }
    }
}
