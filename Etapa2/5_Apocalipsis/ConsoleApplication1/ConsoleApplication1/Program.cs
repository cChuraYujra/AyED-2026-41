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
            Console.WriteLine("Responder con Si o NO.");
            Console.Write("¿Tiene comida? : ");
            string comida = Console.ReadLine();
            comida = comida.ToUpper();
            Console.Write("¿Tiene un refugio? : ");
            string refugio = Console.ReadLine();
            refugio = refugio.ToUpper();
            Console.Write("¿Tiene un bate? : ");
            string bate = Console.ReadLine();
            bate = bate.ToUpper();
            Console.Write("¿Tiene agua? : ");
            string agua = Console.ReadLine();
            Console.Write("¿Tiene un botiquín? : ");
            string botequín = Console.ReadLine();
            botequín = botequín.ToUpper();

            if (comida == "SI" && refugio == "SI" && comida == "SI" && bate == "SI" && agua == "SI")
            {
                Console.Write("Usted sobrevive al apocalipsis");
            }
            else if (comida == "SI" && refugio == "SI" && comida == "SI" && bate == "SI" && agua == "NO")
                Console.ReadKey();
        }
    }
}
