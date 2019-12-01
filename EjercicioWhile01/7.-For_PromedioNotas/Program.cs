using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._For_PromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. En el curso de Matemática Discreta, se toman 6 evaluaciones de las cuales se elimina la
                    menor nota antes de hallar el promedio. Considere que sólo se elimina la menor una sola vez,
                    es decir por ejemplo si la menor nota estuviese duplicada o triplicada, sólo se eliminará una
                    de ellas. Se le pide que elabore un programa en que permita leer las calificaciones de un
                    alumno, almacenarlas en un arreglo y finalmente calcule e imprima el promedio de notas del
                    alumno.
                    Ejemplo 1:
                    Si las notas que se ingresan fueran: 13, 20, 14, 12, 16, 17
                    La nota que no se considera en el promedio seria 12
                    Ejemplo 2:
                    Si las notas que se ingresan fueran: 15, 16, 11, 17, 11, 19
                    La nota que no se considera en el promedio seria el 11 (nota que esta duplicada, sólo se
                    elimina un sólo 11)*/

            //int[] vectorNota = new int[7];

            int[] n = new int[6];
            int min = 20;
            double sum = 0;

            for (int i = 0; i < n.Length; ++i)
            {
                do // se pide las notas
                {
                    Console.Write("nota " + (1 + i) + ": ");
                    n[i] = Convert.ToInt32(Console.ReadLine());
                } while (n[i] < 0 || n[i] > 20);

                min = n[i] < min ? n[i] : min;
                sum += n[i];
            }

            Console.WriteLine("promedio: " + (sum - min) / 5);
            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
