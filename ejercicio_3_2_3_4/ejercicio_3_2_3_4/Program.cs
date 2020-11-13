using System;

namespace ejercicio_3_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double e;
            double n;
            double i = 0.03d;

            Console.Write("Escribe los euros: ");
            e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe los años: ");
            n = Convert.ToDouble(Console.ReadLine());
            
            double resultado = e * Math.Pow(i + 1, n);

            Console.WriteLine("Resultado: {0}", resultado);

            // Añadido para que veáis la evolución anual
            Console.WriteLine("\n\nEvolución anual:");

            for (int j = 1; j <= n; j++)
            {
                resultado = e * Math.Pow(i + 1, j);

                Console.WriteLine("Resultado año {0}: {1}", j, resultado);
            }
        }
    }
}
