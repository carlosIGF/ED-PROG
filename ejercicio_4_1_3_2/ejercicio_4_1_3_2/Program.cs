using System;
using System.Runtime.Serialization.Formatters;

namespace ejercicio_4_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int numeroElementos;
            int media = 0;

            Console.Write("Tamaño del array: ");
            numeroElementos = Convert.ToInt32(Console.ReadLine());

            numeros = new int[numeroElementos];

            for (int i = 0; i < numeroElementos; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeroElementos; i++)
            {
                media += numeros[i];
            }

            media /= numeroElementos;

            Console.WriteLine("La media es {0}", media);
        }
}
