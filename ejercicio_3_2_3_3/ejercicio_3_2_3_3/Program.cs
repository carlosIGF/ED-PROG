using System;

namespace ejercicio_3_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double D;

            Console.Write("Escribe A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe C: ");
            C = Convert.ToDouble(Console.ReadLine());

            D = Math.Sqrt(Math.Pow(B, 2) - 4 * A * C);

            if (Double.IsNaN(D))
            {
                Console.WriteLine("No tiene solución. Raíz cuadrada negativa.");
            }
            else
            {
                double y1 = (-B + D) / 2 * A;
                double y2 = (-B - D) / 2 * A;

                Console.WriteLine("{0}x² + {1}x + {2} = 0", A, B, C);
                Console.WriteLine("y1 = {0}", y1);
                Console.WriteLine("y2 = {0}", y2);
            }
        }
    }
}
