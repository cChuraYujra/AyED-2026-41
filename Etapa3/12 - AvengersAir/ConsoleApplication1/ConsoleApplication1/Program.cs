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
            int opc = 0;
            int disponibles = 80;
            int ocupados = 0;
            int contador = 0;

            int[,] asientos = new int[20, 4];

            string[,] tabla = new string[81, 8];

            while(opc != 7)
            {
                Console.WriteLine("--------------------------------------------------\nMenú Principal - AvengersAir Vuelo Buenos Aires a Wakanda\n--------------------------------------------------\n  Asientos Disponibles: " + disponibles + "\n  Asientos Ocupados: " + ocupados);
                Console.WriteLine("\n1. Vender Asiento\n2. Devolver Asiento\n3. Modificar Asiento\n4. Calcular Ventas\n5. Buscar Pasajeros por Edad\n6. Obtener Asientos con DNI Par\n7. Salir\n--------------------------------------------------");
                Console.Write("Ingrese la opción deseada : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:

                        Console.WriteLine("\nASIENTOS DISPONIBLES\n");

                        for (int i = 0; i < asientos.GetLength(0); i++)
                        {
                            for (int j = 0; j < asientos.GetLength(1); j++)
                            {
                                if (j == 0 || j == 3)
                                {
                                    contador += 2;
                                    asientos[i, j] += contador;
                                }
                            }
                        }
                        contador -= 81;
                        for (int i = 0; i < asientos.GetLength(0); i++)
                        {
                            for (int j = 0; j < asientos.GetLength(1); j++)
                            {
                                if (j == 1 || j == 2)
                                {
                                    contador += 2;
                                    asientos[i, j] += contador;
                                }
                            }
                        }


                        for (int x = 0; x < asientos.GetLength(0); x++)
                        {
                            for (int y = 0; y < asientos.GetLength(1); y++)
                            {
                                Console.Write(asientos[x, y] + " ");
                            }
                            Console.WriteLine();
                        }


                        Console.WriteLine("\nTABLA DE ASIENTOS\n");
                        Console.WriteLine("N° Asiento|Tipo de Asiento|Nombre|Apellido|Edad|DNI|Nacionalidad|Ocupado");
                        for(int i = 0; i < tabla.GetLength(0); i++)
                        {
                            for(int j = 0; j < tabla.GetLength(1); j++)
                            {

                            }
                        }
                        
                        
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 7:
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
