using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int[] vidaPokemones = new int[6];

            Console.Write("-------------------------------------|\nC E N T R O  P O K É - R E M E D I O |\n-------------------------------------|");
            Console.Write("\n1_ Registrar nuevo pokémon\n2_ Mostrar la vida de todos los pokemones\n3_ Curar un pokémon\n4_ Dañar un pokémon\n5_ Curar a todos los pokemones\n6_ Mostrar pokemones debilitados\n7_ Mostrar el pokémon con mayor vida\n8_ Mostrar el pokémon con menor vida\n9_ Calcular promedio de vida del equipo\n10_ Ordenar pokemones por vida de menor a mayor\n11_ Ordenar pokemones por vida de mayor a menor\n12_ Simular ataque enemigo a todo el equipo\n13_ Salir\nOpcion : ");
            opcion = int.Parse(Console.ReadLine());

            while(opcion != 13)
            {
                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < 1; i++)
                        {
                            Console.Write("Ingrese la vida del pokémon : ");
                            int vida = int.Parse(Console.ReadLine());
                        }
                        break;
                }
            }



            Console.ReadKey();
        }        
    }
}
