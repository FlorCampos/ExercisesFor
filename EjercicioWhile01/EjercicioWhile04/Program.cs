using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile04
{
    class Program
    {
        static void Main(string[] args)
        {
            // dibujar su arbolito de navidad
            // entre [5, 10] filas. Ejemplo:
            // si ingresa filas == 6
            //
            //         *
            //        ***
            //       *****
            //      *******
            //     *********
            //    ***********
            //        ***
            //        ***
            //        ***

            Console.Write("\n\tIngrese cantidad de filas [5,10]: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            string star = "*";
            string espacio = "";
            int contadorEspacio = filas;
           
            while (contador >= 0 && contador < filas)
            {


                Console.Write(espacio);
                espacio += " ";
                --contadorEspacio;

                Console.WriteLine("\n\t" + star);
                star += "**";
                ++contador;
                
            }
            string contTronco = "***";
            Console.WriteLine("\n\t" + contTronco);
            Console.WriteLine("\n\t" + contTronco);
            Console.WriteLine("\n\t" + contTronco);

            Console.ReadKey();
        }
    }
}
