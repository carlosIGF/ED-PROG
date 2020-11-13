using System;

namespace Ejercicio_4_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = {31,28,31,30,31,30,31,31,30,31,30,31};
            int mes;

            Console.Write("Introduce el mes (1 = enero, 12 = diciembre): ");
            mes = Convert.ToInt32(Console.ReadLine());

            mes--; // Decrementamos en uno para acceder correctamente al array.

            try
            {
                Console.WriteLine("El mes tiene {0} días.", meses[mes]);
            }
            catch (Exception)
            {
                Console.WriteLine("Mes desconocido.");
            }
        }
    }
}
