using System;

namespace ejercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double media = 0.0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                media += numeros[i];
            }

            media /= 10;

            Console.WriteLine("Número por encima de la media {0}:", media);

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] >= media)
                    Console.WriteLine(numeros[i]);
            }

            

        }
    }
}
