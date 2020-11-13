using System;

namespace Ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];

            Console.Write("Número 1: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 2: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 3: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 4: ");
            numeros[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 5: ");
            numeros[4] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Número 5: {0}.", numeros[4]);
            Console.WriteLine("Número 4: {0}.", numeros[3]);
            Console.WriteLine("Número 3: {0}.", numeros[2]);
            Console.WriteLine("Número 2: {0}.", numeros[1]);
            Console.WriteLine("Número 1: {0}.", numeros[0]);
        }
    } 
}