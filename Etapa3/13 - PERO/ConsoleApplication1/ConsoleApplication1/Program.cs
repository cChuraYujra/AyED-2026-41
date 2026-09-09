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
            int mision = 0;
            int[,] PERO = new int[30, 5];
            Random rand = new Random();
            int opcion;
            int contador = 0;
            int ID = 0;
            int mapas = 1;
            int objetos = 2;
            int nivel = 3;
            int estado = 4;
            int tipoMapa = 0;
            int difilcutad = 0;
            int etapa = 0;
            int articulos = 0;
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
                contador++;
                switch (opcion)
                {
                    case 1:
                        PERO[mision, ID] += contador;

                        Console.Write("\nELije el mapa : \n\n1. Hagwarts\n2. La Casa del Viejo\n3. El Laboratorio\n\nMapa : ");
                        tipoMapa = int.Parse(Console.ReadLine());

                        if (tipoMapa < 1 || tipoMapa > 3)
                        {
                            while (tipoMapa < 1 || tipoMapa > 3)
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo.");
                                Console.Write("\nIntente de nuevo : ");
                                tipoMapa = int.Parse(Console.ReadLine());
                            }
                        }

                        PERO[mision, mapas] = tipoMapa;

                        articulos = rand.Next(1, 70);

                        PERO[mision, objetos] = articulos;

                        Console.WriteLine("\nIngrese la dificultad del nivel\n\n1. Muy Facíl\n2. Facíl\n3. Normal\n4. Dificíl\n5. Imposible\n");
                        Console.Write("Dificultad : ");
                        difilcutad = int.Parse(Console.ReadLine());

                        if (difilcutad > 5)
                        {
                            while (difilcutad > 5)
                            {
                                Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                                Console.Write("\nIntente de nuevo : ");
                                difilcutad = int.Parse(Console.ReadLine());
                            }
                        }
                        PERO[mision, nivel] = difilcutad;

                        Console.WriteLine("Ingrese el estado de la misión\n\n0. Pendiente\n1. En curso\n2. Finalizado\n");
                        Console.Write("Estado : ");
                        etapa = int.Parse(Console.ReadLine());

                        if (etapa > 2)
                        {
                            while (etapa > 2)
                            {
                                Console.WriteLine("Por favor ingrese una opción válida...\n");
                                Console.Write("Estado : ");
                                etapa = int.Parse(Console.ReadLine());
                            }
                        }

                        PERO[mision, estado] = etapa;


                        Console.WriteLine("\nPresiona cualquier botón");
                        Console.ReadLine();
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
                        Console.WriteLine("\nOpción: " + opcion);
                        Console.WriteLine();
                        for (int i = 0; i < mision + 1; i++)
                        {
                            for (int j = 0; j < PERO.GetLength(1); j++)
                            {
                                Console.Write(PERO[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        mision++;
                        Console.WriteLine(contador);
                        break;
                    case 2:
                        for(int i = 0; i < contador - 1; i++)
                        {
                            for(int j = 0; j < PERO.GetLength(1); j++)
                            {
                                Console.Write(PERO[i, j] + " ");                                                               
                            }
                            Console.WriteLine("\nID : " + PERO[i, ID]);
                            Console.WriteLine("Mapa : ");
                            if (PERO[j, mapas] == 1)
                            {
                                Console.Write("Hagwarts");
                            }
                            else if (PERO[j, mapas] == 2)
                            {
                                Console.Write("La Casa del Viejo");
                            }
                            else
                            {
                                Console.Write("El Laboratorio");
                            }                                                          
                        }
                        break;
                    case 3:
                        // Punto 3: Cambiar estado de misión
                        break;
                    case 4:
                        // Punto 4: Listar misiones en curso
                        break;
                    case 5:
                        // Punto 5: Misión con más objetos a extraer
                        break;
                    case 6:
                        // Punto 6: Promedio de peligro por mapa
                        break;
                    case 7:
                        // Punto 7: Filtrar por mapa
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
