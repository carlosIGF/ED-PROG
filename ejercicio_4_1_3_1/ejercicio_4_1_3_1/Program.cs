using System;

namespace ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] numeros = new short[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                numeros[i] = Convert.ToByte(Console.ReadLine());
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
