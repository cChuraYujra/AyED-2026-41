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

            int[] Resgistro = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Resgistro[i] = registrar();
            }



            Console.ReadKey();
        }
        static void registrar()
        {
            Pasajes p = new Pasajes();
            Console.Write("ID:\t");
            p.getid = int.Parse(Console.ReadLine());
            Console.Write("NOmbre:\t");
            p.getnombre = Console.ReadLine();
            Console.Write("Destino:\t");
            p.getdestino = Console.ReadLine();
            Console.Write("Precio:\t");
            p.getprecio = int.Parse(Console.ReadLine());
            Console.Write("Asientos comprados:\t");
            p.getasientosAdquiridos = int.Parse(Console.ReadLine());

        }
        
    }
    class Pasajes
    {
        private int id;
        private string nombre;
        private string destino;
        private int precio;
        private int asientosAdquiridos;

        public Pasajes(int id, string nombre, string destino, int precio, int asientosAdquiridos)
        {
            this.id = id;
            this.nombre = nombre;
            this.destino = destino;
            this.precio = precio;
            this.asientosAdquiridos = asientosAdquiridos;
        }
        public void mostrainfo()
        {
            Console.WriteLine("Recaudación final: ");
            Console.WriteLine("Asientos vendidos: ");
            Console.WriteLine("Promedio de compras: ");
            Console.WriteLine("Nombres compra mayor $200.000: ");
            Console.WriteLine("Compras mayores de $200.000");
            Console.WriteLine("Porcentaje superiores a $200.000: ");
            Console.WriteLine("Destino de la compra de mayor importe: ");
        }

        public int getid()
        {
            return id;
        }
        public int getnombre()
        {
            return nombre;
        }
        public int getdestino()
        {
            return destino;
        }
        public int getprecio()
        {
            return precio;
        }
        public int getasientosAdquiridos()
        {
            return asientosAdquiridos;
        }

    }
}
