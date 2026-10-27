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
            //Variables de las columnas
            int NumeroDeAsiento = 0;
            int TipoDeAsiento = 1;
            int Nombre = 2;
            int Apellido = 3;
            int Edad = 4;
            int DNI = 5;
            int Nacionalidad = 6;
            int Ocupado = 7;
            //FIn

            //Variables para el código
            int Nro_Asiento = 0;
            string asiento;
            string Name;
            string LastName;
            int Age;
            int ID;
            string Nationality;
            bool Busy;
            //FIN

            //Variales utiles
            int AsientosLibres = 80;
            int AsientosOcupados = 0;
            int opcion;
            int contador = 1;
            //FIN

            //Matriz/ces
            int[,] Asientos = new int[80, 8];
            int[,] Tablita = new int[80, 3];
            //FIN            

            for (int i = 0; i < Tablita.GetLength(0); i++)
            {
                for (int j = 0; j < Tablita.GetLength(1); j++)
                {
                    Tablita[i, 0] = i + 1;
                    if (Tablita[i, 0] > 0 && Tablita[i, 0] < 40)
                    {
                        Tablita[i, 1] = 0;
                    }
                    else if (Tablita[i, 0] >= 40 && Tablita[i, 0] <= 43)
                    {
                        Tablita[i, 1] = 1;
                    }
                    else
                    {
                        Tablita[i, 1] = 2;
                    }
                }
            }
            for (int i = 0; i < Asientos.GetLength(0); i++)
            {
                for (int j = 0; j < Asientos.GetLength(1); j++)
                {
                    Asientos[i, 0] = i + 1;
                    if (Asientos[i, 0] > 0 && Asientos[i, 0] < 40)
                    {
                        Asientos[i, 1] = 0;
                    }
                    else if (Asientos[i, 0] >= 40 && Asientos[i, 0] <= 43)
                    {
                        Asientos[i, 1] = 1;
                    }
                    else
                    {
                        Tablita[i, 1] = 2;
                    }
                }
            }

            do
            {
                Console.Clear();
                Console.Write("------------------------------------------------------------\nMenu Principal - AvengersAir  Vuelo Buenos Aires a Wakanda\n------------------------------------------------------------\n\n   Asiento Disponibles: " + AsientosLibres + "\n\n   Asientos Ocupados: " + AsientosOcupados + "\n\n 1.   Vender Asiento.\n 2.   Devolver Asiento.\n 3.   modificar Asiento.\n 4.   Calcular Ventas\n 5.   Buscar Pasajeros por Edad\n 6.   Buscar Pasajeros por DNI.\n 7.   Salir.\n\n------------------------------------------------------------\nIngrese la opción deseada: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" Nro | Tipo | Ocupado");
                        for (int i = 0; i < Tablita.GetLength(0); i++)
                        {
                            for (int j = 0; j < Tablita.GetLength(1); j++)
                            {
                                if (Tablita[i, 2] == 0)
                                {
                                    Console.Write(Tablita[i, j] + "\t");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("-----------------------");
                        Console.Write("Elija un asiento : ");
                        int AsientoSeleccionado = int.Parse(Console.ReadLine());
                        if (AsientoSeleccionado < 1 || AsientoSeleccionado >= 80)
                        {
                            while(AsientoSeleccionado < 1 || AsientoSeleccionado >= 80)
                            {
                                Console.WriteLine("Este asiento NO EXISTE. Intentelo de nuevo");
                                Console.Write("Elija un asiento : ");
                                AsientoSeleccionado = int.Parse(Console.ReadLine());
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Ingrese sus datos personales.");
                        for (int j = 0; j < Asientos.GetLength(1); j++)
                        {
                            Console.Write("Nombre : ");
                            Name = Console.ReadLine();
                            Asientos[AsientoSeleccionado, j] = Name;
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);

            Console.ReadKey();

        }
    }
}
