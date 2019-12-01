using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imprimir números del 1 al 10*/

            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine(x);
            }

            for (int x = 1, y = 5; x != y; x++ , y--)
            {
                Console.WriteLine(x + ", " + y);
            }

            Console.ReadKey();
        }
    }
}
