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
            Console.Write("Ingrese su contraseña : ");
            string contraseña = Console.ReadLine();
            string contraseñaMa = contraseña.ToUpper();
            Console.Write("¿Cúal es su contraseña? : ");
            string contraseña1 = Console.ReadLine();
            string contraseña1Ma = contraseña1.ToUpper();

            if (contraseñaMa == contraseña1Ma)
            {
                Console.WriteLine("Contraseña Correcta");
            }
            else
            {
                Console.WriteLine("Contraseña Incorrecta, intentelo de nuevo.");
            }
            Console.ReadKey();
        }
    }
}
