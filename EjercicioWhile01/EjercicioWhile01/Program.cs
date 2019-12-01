using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir N enteros hasta que se ingrese CERO
             * luego imprimir la suma de todos los dígitos.
             * Ingreso:
             *          234
             *          768  
             *          0
             * Salida:
             *          30
             */
            //int numero, suma, dig;
            //do
            //{
            //    Console.Write("Ingrese número: ");
            //    numero = Convert.ToInt32(Console.ReadLine());




            //} while (numero != 0);

            //Console.WriteLine("La suma de los dígitos es : ");
            //Console.ReadKey();
            int sum = 0;

            while (true)
            {
                Console.Write("Ingrese número [0=FIN]: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }
                while (x >0)
                {
                    sum += x % 10;
                    x /= 10;
                }
            }

            Console.WriteLine("La suma de los dígitos es : " + sum);
            Console.ReadKey();
            // También se puede hacer con do - while
        }
    }
}
