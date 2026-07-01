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
            int opcion = 0;
            int posicion = 0;
            int enLista = 0;            

            int[] vidaPokemones = new int[6];

            while (opcion != 13)
            {
                Console.Write("-------------------------------------|\nC E N T R O  P O K É - R E M E D I O |\n-------------------------------------|");
                Console.Write("\n1_ Registrar nuevo pokémon\n2_ Mostrar la vida de todos los pokemones\n3_ Curar un pokémon\n4_ Dañar un pokémon\n5_ Curar a todos los pokemones\n6_ Mostrar pokemones debilitados\n7_ Mostrar el pokémon con mayor vida\n8_ Mostrar el pokémon con menor vida\n9_ Calcular promedio de vida del equipo\n10_ Ordenar pokemones por vida de menor a mayor\n11_ Ordenar pokemones por vida de mayor a menor\n12_ Simular ataque enemigo a todo el equipo\n13_ Salir\n\nOpcion : ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("ERROR, ingrese un numero del menú de opciones.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        if (enLista < 6)
                        {
                            Console.Write("\nIngrese la vida del pokémon : ");
                            vidaPokemones[posicion] = int.Parse(Console.ReadLine());
                            if (vidaPokemones[posicion] > 100)
                            {
                                Console.Write("Ingrese la vida del pokémon (vida entre 1 y 100): ");
                                vidaPokemones[posicion] = int.Parse(Console.ReadLine());
                                if (vidaPokemones[posicion] >= 100 && vidaPokemones[posicion] >= 0)
                                {
                                    Console.WriteLine("\nPokémon registrado correctamente en la posición " + posicion);
                                    enLista++;
                                }
                            }
                            while (vidaPokemones[posicion] > 100)
                            {
                                if (vidaPokemones[posicion] > 100)
                                {
                                    Console.Write("Ingrese la vida del pokémon (vida entre 1 y 100): ");
                                    vidaPokemones[posicion] = int.Parse(Console.ReadLine());
                                    if(vidaPokemones[posicion] <= 100)
                                    {
                                        Console.WriteLine("\nPokémon registrado correctamente en la posición " + posicion);
                                        enLista++;
                                    }
                                }
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("No se pueden registrar más pokemones. El centro está lleno.");
                        }
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        for (int i = 0; i < posicion; i++)
                        {
                            Console.WriteLine("Pokémon " + i + " - Vida : " + vidaPokemones[i]);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        int lugar;
                        Console.Write("Ingrese la posición del pokémon a curar : ");
                        lugar = int.Parse(Console.ReadLine());
                        if(lugar > enLista)
                        {
                            Console.WriteLine("No exite ningún pokémon en esta casilla.");
                        }
                        else
                        {
                            Console.Write("Ingrese puntos de vida a recuperar : ");
                            int curar = int.Parse(Console.ReadLine());
                            vidaPokemones[lugar] += curar;
                            Console.WriteLine("El pokémon fue curado.");
                            Console.WriteLine("Vida actual : " + vidaPokemones[lugar]);
                        }                                                                           
                        if (vidaPokemones[lugar] > 100)
                        {
                            vidaPokemones[lugar] = 100;
                        }                                               
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Ingrese la posición del pokémon atacado : ");
                        int sitio = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese daño recibido : ");
                        int dañar = int.Parse(Console.ReadLine());
                        vidaPokemones[sitio] -= dañar;
                        if (vidaPokemones[sitio] < 0)
                        {
                            vidaPokemones[sitio] = 0;
                        }
                        Console.WriteLine("El pokémon recibió daño.");
                        Console.WriteLine("Vida actual : " + vidaPokemones[sitio]);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Ingrese puntos de curación general : ");
                        int curaciongeneral = int.Parse(Console.ReadLine());
                        for (int i = 0; i < enLista; i++)
                        {
                            vidaPokemones[i] += curaciongeneral;
                            if (vidaPokemones[i] > 100)
                            {
                                vidaPokemones[i] = 100;
                            }
                        }
                        Console.WriteLine("Todos los pokemones fueron curados.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        int totales = 0;
                        for (int i = 0; i < enLista; i++)
                        {
                            if (vidaPokemones[i] == 0)
                            {
                                totales++;
                            }
                        }
                        if (totales > 0)
                        {
                            Console.WriteLine("Pokemones debilitados : ");
                            for (int i = 0; i < enLista; i++)
                            {
                                if (vidaPokemones[i] == 0)
                                {
                                    Console.WriteLine("Pokémon en posición : " + i);
                                }
                            }
                            Console.WriteLine("\nCantidad total de debilitados : " + totales);
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay pokemones debilitados");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        int mayor = 0;
                        int posicionpokemon = 0;
                        for (int i = 0; i < enLista; i++)
                        {
                            if (vidaPokemones[i] > mayor)
                            {
                                mayor = vidaPokemones[i];
                                posicionpokemon = i;
                            }
                        }
                        Console.WriteLine("El pokémon con mayor vida está en la posición : " + posicionpokemon);
                        Console.WriteLine("Vida : " + mayor);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        int menor = 100;
                        int posicionPokemonMenor = 0;
                        for (int i = 0; i < enLista; i++)
                        {
                            if (vidaPokemones[i] < menor)
                            {
                                menor = vidaPokemones[i];
                                posicionPokemonMenor = i;
                            }
                        }
                        Console.WriteLine("El pokémon con menor vida está en la posición : " + posicionPokemonMenor);
                        Console.WriteLine("Vida : " + menor);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        int promedio = 0;
                        for (int i = 0; i < enLista; i++)
                        {
                            promedio += vidaPokemones[i];
                        }
                        promedio = promedio / enLista;
                        if (promedio <= 30)
                        {
                            Console.WriteLine("El equipo está en peligro.");
                        }
                        else if (promedio >= 31 && promedio <= 69)
                        {
                            Console.WriteLine("El equipo necesita curación.");
                        }
                        else
                        {
                            Console.WriteLine("El equipo está en buen estado.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 10:
                        Array.Sort(vidaPokemones, 0, enLista);
                        Console.WriteLine("Vidas ordenadas de menor a mayor");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 11:
                        Array.Sort(vidaPokemones);
                        Array.Reverse(vidaPokemones);
                        Console.WriteLine("Vidas ordenadas de mayor a menor");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 12:
                        Random rnd = new Random();
                        int daño = rnd.Next(5, 25);
                        for (int i = 0; i < enLista; i++)
                        {
                            vidaPokemones[i] -= daño;
                            if (vidaPokemones[i] > 100)
                            {
                                vidaPokemones[i] = 100;
                            }
                        }
                        Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                        Console.WriteLine("Daño recibido por todos : " + daño);
                        Console.WriteLine("Las vidas fueron actualizadas.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 13:
                        Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Remedio.");
                        Console.ReadKey();
                        Console.Clear();
                        break;               
                        
                }
            }
        }        
    }
}
