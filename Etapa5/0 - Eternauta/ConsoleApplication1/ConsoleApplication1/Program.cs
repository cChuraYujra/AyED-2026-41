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
            Refugio r101 = new Refugio(101, 20, 12);

            Refugio r102 = new Refugio(102, 15, 10);

            Refugio r103 = new Refugio(103, 30, 25);

            Console.WriteLine("=== SISTEMAS DE REFUGIOS ===\n");
            r101.mostrarInformacion();

            r102.mostrarInformacion();

            r103.mostrarInformacion();

            Console.WriteLine("=== RESUMEN ===\n");

            Console.WriteLine("Personas alojadas: \t" + (r101.getpipolAlojadas() + r102.getpipolAlojadas() + r103.getpipolAlojadas()));
            Console.WriteLine("Lugares disponibles: \t" + (r101.calcularDisponible() + r102.calcularDisponible() + r103.calcularDisponible()));
            Console.Write("Refugio con mayor capacidad: \t");
            if (r101.getcapaMax() > r102.getcapaMax() && r101.getcapaMax() > r103.getcapaMax())
            {
                Console.WriteLine(r101.getnumero());
            }
            else if(r102.getcapaMax() > r101.getcapaMax() && r102.getcapaMax() > r103.getcapaMax())
            {
                Console.WriteLine(r102.getnumero());
            }
            else
            {
                Console.WriteLine(r103.getnumero());
            }

            Console.ReadKey();
        }
    }
    class Refugio
    {
        private int numero;
        private int capaMax;
        private int pipolAlojadas;

        public Refugio(int numero, int capaMax, int pipolAlojadas)
        {
            this.numero = numero;
            this.capaMax = capaMax;
            this.pipolAlojadas = pipolAlojadas;
        }

        public int calcularDisponible()
        {
            int disponibles = capaMax - pipolAlojadas;
            return disponibles;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("Refugio \t" + numero);
            Console.WriteLine("Capacidad: \t" + capaMax);
            Console.WriteLine("Alojados: \t" + pipolAlojadas);
            Console.WriteLine("Disponible: \t" + (calcularDisponible()) + "\n");
        }
        public int getpipolAlojadas()
        {
            return pipolAlojadas;
        }
        public int getcapaMax()
        {
            return capaMax;
        }
        public int getnumero()
        {
            return numero;
        }
    }
}
