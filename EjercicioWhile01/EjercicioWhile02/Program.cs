using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir N valores hasta que se ingrese CERO
             * luego imprimir la suma, el mayor, el menor, el promedio de todos los valores ingresados.
             * Excepto el cero */
            double sum = 0 , cuantos = 0, max =0, min =0;
            
            //double min = Double.MaxValue; // es el menor de todos los números reales10mim max
            //double max = Double.MinValue;

            while (true)
            {
                Console.Write("Ingrese valor [0=FIN]: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }
                ++cuantos;

                if (cuantos ==1)
                {
                    max = min = x;
                }

                max = (x > max) ? x : max;
                min = (x < min) ? x : min;
                sum +=x;
            }

            if (cuantos > 0)
            {
                Console.WriteLine("La suma es : " + sum);
                Console.WriteLine("El máx valor es :" + max);
                Console.WriteLine("El min valor es :" + min);
                Console.WriteLine("Promedio : " + (sum / cuantos));

            }
            else
            {
                Console.WriteLine("No ingresó valor válido");
            }
                                   
            Console.ReadKey();
            // También se puede hacer con do - while 
        }
    }
}
