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
            int pago;
            int diezm = 0;
            int dosm = 0;
            int mil = 0;
            int quin = 0;
            int dosc = 0;
            int cien = 0;
            int cincuenta = 0;
            int veinte = 0;
            int diez = 0;
            int vuelto;
            Console.Write("Ingrese el monto total de una compra: ");
            int monto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el dinero entregado para pagar: ");
            pago = int.Parse(Console.ReadLine());
            vuelto = pago - monto;
            Console.Write("Vuelto: ");
            Console.WriteLine(vuelto);
            while (vuelto >= 10000)
            {
                diezm = diezm + 1;
                vuelto = vuelto - 10000;
            }
            while (vuelto >= 2000)
            {
                dosm = dosm + 1;
                vuelto = vuelto - 2000;
            }
            while (vuelto >= 1000)
            {
                mil = mil + 1;
                vuelto = vuelto - 1000;
            }
            while (vuelto >= 500)
            {
                quin = quin + 1;
                vuelto = vuelto - 500;
            }
            while (vuelto >= 200)
            {
                dosc = dosc + 1;
                vuelto = vuelto - 200;
            }
            while (vuelto >= 100)
            {
                cien = cien + 1;
                vuelto = vuelto - 100;
            }
            while (vuelto >= 50)
            {
                cincuenta = cincuenta + 1;
                vuelto = vuelto - 50;
            }
            while (vuelto >= 20)
            {
                veinte = veinte + 1;
                vuelto = vuelto - 20;
            }
            while (vuelto >= 10)
            {
                diez = diez + 1;
                vuelto = vuelto - 10;
            }
            Console.WriteLine("Billetes de diez mil: " + diezm);
            Console.WriteLine("Billetes de dos mil: " + dosm);
            Console.WriteLine("Billetes de mil: " + mil);
            Console.WriteLine("Billetes de quinientos: " + quin);
            Console.WriteLine("Billetes de doscientos: " + dosc);
            Console.WriteLine("Billetes de cien: " + cien);
            Console.WriteLine("Billetes de cincuenta: " + cincuenta);
            Console.WriteLine("Billetes de veinte: " + veinte);
            Console.WriteLine("Billetes de diez: " + diez);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
