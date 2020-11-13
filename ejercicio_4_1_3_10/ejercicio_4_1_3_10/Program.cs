using System;

namespace ejercicio_4_1_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int producto = 0;

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
                producto += (vector1[i] * vector2[i]);

            Console.WriteLine("El producto escalar es {0}", producto);
        }
    }
}
