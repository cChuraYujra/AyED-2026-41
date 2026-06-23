using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.Write("Ingrese la cantidad de exámenes: ");
            int cantExamenes = int.Parse(Console.ReadLine());
            double[] notasExamenes = new double[cantExamenes];
            double sumaExamenes = 0;

            for (int i = 0; i < cantExamenes; i++)
            {
                Console.Write("Ingrese la nota del examen " + (i + 1) + "(0-10) : ");
                notasExamenes[i] = double.Parse(Console.ReadLine());
                sumaExamenes += notasExamenes[i];
            }
      
            Console.Write("\nIngrese la cantidad de Trabajos Prácticos (TPs): ");
            int cantTPs = int.Parse(Console.ReadLine());
            double[] notasTPs = new double[cantTPs];
            int tpsAprobados = 0;

            for (int i = 0; i < cantTPs; i++)
            {
                Console.Write($"Ingrese la nota del TP " + (i + 1) + "(0-10): ");
                notasTPs[i] = double.Parse(Console.ReadLine());

                if (notasTPs[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            double promedioExamenes = 0;
            if (cantExamenes > 0)
            {
                promedioExamenes = sumaExamenes / cantExamenes;
            }

            double porcentajeTPsAprobados = 0;
            if (cantTPs > 0)
            {
                porcentajeTPsAprobados = (tpsAprobados / cantTPs) * 100;
            }

            bool apruebaExamenes = promedioExamenes >= 6;
            bool apruebaTPs = porcentajeTPsAprobados >= 75;

            Console.WriteLine("\nPromedio de exámenes : " + promedioExamenes);
            Console.WriteLine("\nPorcentaje de TPs aprobados: " + porcentajeTPsAprobados + "%");

            if (apruebaExamenes && apruebaTPs)
            {
                Console.WriteLine("\nPueden aprobar la materia.");
            }
            else
            {
                Console.WriteLine("\nPhineas y Ferb, no cumplen con los requisitos para aprobar la materia.");
            }
            Console.ReadKey();
        }
    }
}
