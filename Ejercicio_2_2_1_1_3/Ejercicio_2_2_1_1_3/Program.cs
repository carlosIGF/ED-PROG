using System;

namespace Ejercicio_2_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = -1;
            int n2 = -1;

            while ((n1 != 0) || (n2 != 0))
            {
                Console.Write("Número 1: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Número 2: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 % n2 == 0)
                    Console.WriteLine("{0} es múltiplo de {1}", n1, n2);
                else
                    if (n2 % n1 == 0)
                        Console.WriteLine("{0} es múltiplo de {1}", n2, n1);
                    else
                        Console.WriteLine("No son múltiplos.");
            }
        }
    }
}
