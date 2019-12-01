using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Demostración de que 7 tiene mayor posibilidad de salir al lanzar 2 dados. */

            Random r = new Random();
            int[] cta = new int[13]; // truquito 1: para que el índice del vector coincida con los posibles resultados de la suma

            for (int i = 0; i < 10000; i++) //simula 10000 lanzamientos de dados. Así será más exacto
            {
                int d1 = r.Next(1, 7);  // dado 1
                int d2 = r.Next(1, 7); // dado 2

                int sum = d1 + d2;
                ++cta[sum]; //truquito 2 : colocar el resultado de la suma como índice del vector para que incremente el contador 
                //de esa posición
            }

            for (int i = 2; i < cta.Length; i++)
            {
                Console.WriteLine(i + " salió " + cta[i] + " veces");
            }

            Console.ReadKey();
        }
    }
}
