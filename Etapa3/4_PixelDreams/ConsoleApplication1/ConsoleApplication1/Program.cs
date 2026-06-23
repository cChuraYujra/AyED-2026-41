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
            Console.Write("Ingrese la cantidad de particpantes del torneo : ");
            int TotalParticipantes = int.Parse(Console.ReadLine());
            int[] Participantes = new int[TotalParticipantes];
            for (int i = 0; i < TotalParticipantes; i++)
            {
                Console.Write("Ingrese el puntaje del jugador " + (i + 1) + " : ");
                Participantes[i] = int.Parse(Console.ReadLine());
            }


            Array.Sort(Participantes);

            Console.WriteLine("El primero puesto con : " + Participantes[TotalParticipantes - 1]);
            Console.WriteLine("El ultimo puesto con : " + Participantes[0]);

            Array.Reverse(Participantes);
        
            foreach (int puntaje in Participantes)
            {
                Console.WriteLine(puntaje);
            }
            Console.ReadKey();
        }
    }
}
