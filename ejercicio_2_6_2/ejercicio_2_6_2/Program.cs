using System;

namespace ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisor = 2;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 1)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    numero = numero / divisor;
                }
                else
                    divisor++;
            }
        }
    }
}
