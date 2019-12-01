using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ramdom*/
            Random r = new Random();

            //[0,9]
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(r.Next(10));
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(r.Next(1,11)); //es cerrado por la izquierda y abierto por la derecha
            //}

            //Imprimir números de 2 dígitos 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(10, 100)); //es cerrado por la izquierda y abierto por la derecha
            }

            //Imprimir entre [-1, 1]
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(-1, 2)); //es cerrado por la izquierda y abierto por la derecha
            }

            //Imprimir entre [0, 1]
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(0, 2)); //es cerrado por la izquierda y abierto por la derecha
            }

            Console.ReadKey();
        }
    }
}
