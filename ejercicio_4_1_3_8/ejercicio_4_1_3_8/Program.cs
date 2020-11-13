using System;

namespace ejercicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[3];
            double modulo = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Componente {0}: ", i + 1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                modulo += Math.Pow(vector[i], 2);
            }

            modulo = Math.Sqrt(modulo);

            Console.WriteLine("El módulo es {0}.", modulo);

        }
    }
}
