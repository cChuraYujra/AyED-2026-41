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
            int tipoMapa;
            int difilcutad;
            int etapa;
            int articulos;
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
                        contador++;
                        PERO[mision, ID] = contador;

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
                        Console.WriteLine("\nID : " + contador);
                        Console.Write("Tipo de Mapa : ");
                        if (tipoMapa == 1)
                        {
                            Console.WriteLine("Hagwarts");
                        }
                        else if (tipoMapa == 2)
                        {
                            Console.WriteLine("La Casa del Viejo");
                        }
                        else
                        {
                            Console.WriteLine("El Laboratorio");
                        }
                        Console.WriteLine("Objetos a extraer : " + articulos);
                        Console.Write("Nivel de peligro : ");
                        if (difilcutad == 1)
                        {
                            Console.WriteLine("Muy Facíl");
                        }
                        else if (difilcutad == 2)
                        {
                            Console.WriteLine("Facíl");
                        }
                        else if (difilcutad == 3)
                        {
                            Console.WriteLine("Normal");
                        }
                        else if (difilcutad == 4)
                        {
                            Console.WriteLine("Dificíl");
                        }
                        else
                        {
                            Console.WriteLine("Imposible");
                        }
                        Console.Write("Estado : ");
                        if(etapa == 0)
                        {
                            Console.WriteLine("Pendiente");
                        }
                        else if (etapa == 1)
                        {
                            Console.WriteLine("En Curso");
                        }
                        else
                        {
                            Console.WriteLine("Finalizado");
                        }
                        mision++;
                        Console.WriteLine(contador);
                        break;
                    case 2:
                        for (int i = 0; i < contador; i++)
                        {
                            
                            for (int j = 0; j < PERO.GetLength(1); j++)
                            {
                                Console.Write(PERO[i, j] + " ");
                            }
                            Console.WriteLine();
                            for(int x = 0; x < contador; x++)
                            {
                                for(int y = 0; y < PERO.GetLength(1); y++)
                                {

                                }
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
