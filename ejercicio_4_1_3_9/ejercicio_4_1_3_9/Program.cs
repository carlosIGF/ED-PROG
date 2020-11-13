using System;

namespace ejercicio_4_1_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int[] suma = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Componente V1 {0}: ", i + 1);
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Componente V2 {0}: ", i + 1);
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                suma[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("La suma es [{0}, {1}, {2}].", suma[0], suma[1], suma[2]);
        }
    }
}
