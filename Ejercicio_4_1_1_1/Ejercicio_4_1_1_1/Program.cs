using System;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];

            Console.Write("Número 1: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 2: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 3: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 4: ");
            numeros[3] = Convert.ToDouble(Console.ReadLine());

            double media = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4.0;

            Console.WriteLine("La media aritmética de {0}, {1}, {2} y {3} es: {4}.",
                numeros[0], numeros[1], numeros[2], numeros[3], media);
        }
    }
}
