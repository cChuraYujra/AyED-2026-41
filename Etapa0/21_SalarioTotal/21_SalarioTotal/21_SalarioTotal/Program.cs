using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SalarioTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas trabajadas : ");
            double HorasTrabajadas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el salario por hora : ");
            double SalarioHora = double.Parse(Console.ReadLine());
            double SalarioTotal = HorasTrabajadas * SalarioHora;
            Console.WriteLine("El Salario Total es de : " + SalarioTotal);
            Console.ReadKey();

        }
    }
}
