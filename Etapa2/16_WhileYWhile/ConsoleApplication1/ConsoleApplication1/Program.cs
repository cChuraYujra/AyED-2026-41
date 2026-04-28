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
            Console.WriteLine("Numeros impares del 0 al 100 : ");
            while (contador <= 100)
            {
                if (contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
                else
                {
                    contador++;
                }
            }
            contador = contador - 100;
            Console.WriteLine("Numeros pares del 0 al 100 : ");
            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
                else
                {
                    contador++;
                }
            }
            contador = contador - 100;
            Console.WriteLine("Numeros del 0 al 100 : ");
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine("Numeros del 100 al 0 : ");
            contador--;
            while (contador >= 0)
            {
                Console.WriteLine(contador);
                contador --;
            }contador= contador -2;
            Console.WriteLine("Numeros multiplos de 3 del 0 al 100 : ");
            while (contador < 99)
            {
                contador = contador + 3;
                Console.WriteLine(contador);
            }
            contador = contador - 99 ;
            Console.WriteLine("Numeros multiplos de 3 y de 2 entre el 0 y 100 : ");
            while(contador < 100)
            {
                if (contador % 2 == 0 && contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
                else
                {
                    contador++;
                }

            }

            Console.ReadKey();
        }
    }
}
