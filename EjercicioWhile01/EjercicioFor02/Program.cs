using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Averiguar que se almacena en el vector*/
            //instancia significa pedirle al sistema recursos--qué recurso: memoria temporal(espacio para guardar algo)
            //int[] v = new int[10];
            string[] v = new string[10];
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }

            Console.ReadKey();

            /*Los arreglos en C# ya están inicializados con un valor*/
        }
    }
}
