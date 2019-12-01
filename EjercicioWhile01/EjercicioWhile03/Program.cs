using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dar el valor de x, sabiendo que:
            // X = 100 + 99/2 + 98/3 + 97/4 + ... + 1/100
          
            double x = 101, sum = 0;
            int contador = 1;

            while (contador > 0 && contador <= 100)
            {
                sum += ((x - contador) / contador);
                ++contador;
            }

            Console.WriteLine("La suma es : " + sum);
            Console.ReadKey();
        }
    }
}
