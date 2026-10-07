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
            //Variables para la matriz
            int id = 0;
            int mapa = 1;
            int objetos = 2;
            int nivel = 3;
            int estado = 4;

            //Variables para el código
            int mision = 0;
            int mapas;
            int dificultad;
            int articulos = 0;

            //Matriz
            int[,] PERO = new int[30, 5];


            int contador = 0;
            int opcion;
            Random rand = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de pegrilo por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("\nOpción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (contador > 30)
                        {
                            Console.Write("¡Demasiadas misiones!");
                        }
                        else
                        {
                            contador++;
                            PERO[mision, id] = contador;

                            Console.Write("\n---MAPAS A ELIJIR---\n\n1. Hagwarts\n2. La Casa del Viejo\n3. El Laboratorio\n\nElija un mapa para la misión : ");
                            mapas = int.Parse(Console.ReadLine());

                            if (mapas < 1 || mapas > 3)
                            {
                                while (mapas < 1 || mapas > 3)
                                {
                                    Console.WriteLine("Ese mapa no es de este juegazo.");
                                    Console.Write("\nIntente de nuevo : ");
                                    mapas = int.Parse(Console.ReadLine());
                                }
                            }
                            PERO[mision, mapa] = mapas;
                            articulos = rand.Next(1, 70);
                            PERO[mision, objetos] = articulos;

                            Console.Write("\n--DIFICULTAD--\n\n1. Muy Fácil\n2. Facíl\n3. Nromal\n4. Dificíl\n5. Que dios se apiare de nosotros...\n\nELija una dificultad : ");
                            dificultad = int.Parse(Console.ReadLine());
                            if (dificultad > 5)
                            {
                                while (dificultad > 5)
                                {
                                    Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                                    Console.Write("\nIntente de nuevo : ");
                                    dificultad = int.Parse(Console.ReadLine());
                                }
                            }
                            PERO[mision, nivel] = dificultad;                          
                            PERO[mision, estado] = 0;

                            Console.WriteLine("\nDATOS DE LA NUEVA MISIÓN AÑADIDAS AL SISTEMA.");
                            mision++;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < mision; i++)
                        {
                            for (int j = 0; j < PERO.GetLength(1); j++)
                            {
                                Console.Write(PERO[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese la mision a ascender : ");
                        int a = int.Parse(Console.ReadLine());
                        a--;
                        PERO[a, estado] += 1;
                        if (a > contador)
                        {
                            while (a > contador)
                            {
                                Console.WriteLine("Intente de nuevo.\n");
                                Console.Write("Estado : ");
                                a = int.Parse(Console.ReadLine());
                            }
                        }

                        if (PERO[a, estado] > 2)
                        {
                            PERO[a, estado] = 2;
                            Console.Write("Mision " + (a + 1) + " ya no se puede ascender mas.");
                        }
                        else
                        {
                            Console.Write("Misión " + (a + 1) + " a sido ascendido.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Las misiones en estado de En Curso son : ");
                        for (int i = 0; i < mision; i++)
                        {
                            for (int j = 0; j < PERO.GetLength(1); j++)
                            {
                                if(PERO[i, estado] == 1)
                                {
                                    Console.Write(PERO[i, j] + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("La misión con más objetos a recuperar es : ");
                        int mayor = 0;
                        int b = 0;
                        for(int i = 0; i < mision; i++)
                        {
                            for(int j = 0; j < PERO.GetLength(1); j++)
                            {
                                if(PERO[b, objetos] > mayor)
                                {
                                    mayor = PERO[b, objetos];
                                    b++;
                                }
                                else
                                {
                                    b++;
                                }
                            }
                        }
                        for(int i = 0; i < mision; i++)
                        {
                            for(int j = 0; j < PERO.GetLength(1); j++)
                            {
                                if(PERO[i, objetos] == mayor)
                                {
                                    Console.Write(PERO[i, j] + " ");
                                }
                            }
                        }
                        break;
                    case 6:
                            for (int map = 1; mapa <= 3; mapa++)
                            {
                               int suma = 0;
                               int cantidadMapa = 0;
    
                              for (int i = 0; i < articulos; i++)
                              {
                                if (PERO[i, 1] == mapa)
                                {
                                    suma = suma + PERO[i, 3];
                                    cantidadMapa++;
                                }
                            }

                            if (mapa == 1)
                            {
                                Console.Write("Hagwarts: ");
                            }
                            else if (mapa == 2)
                            {
                                Console.Write("La Casa del Viejo: ");
                            }
                            else
                            {
                                Console.Write("El Laboratorio: ");
                            }

                            if (cantidadMapa > 0)
                            {
                                int promedio = (int)suma / cantidadMapa;
                                Console.WriteLine(promedio);
                            }
                            else
                            {
                                Console.WriteLine("No hay misiones.");
                            }
                        }
                        break;
                    case 7:
                        Console.Write("Ingrese el mapa que quieras buscar : ");
                        int filtrado = int.Parse(Console.ReadLine());

                        for (int i = 0; i < mision; i++)
                        {
                            for(int j = 0; j < PERO.GetLength(1); j++)
                            {
                                if(PERO[i, mapa] == filtrado)
                                {
                                    Console.Write(PERO[i, j] + " ");
                                }                                
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 8);
            Console.ReadKey();
        }
    }
}
