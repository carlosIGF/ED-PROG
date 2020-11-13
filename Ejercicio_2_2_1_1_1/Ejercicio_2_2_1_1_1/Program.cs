using System;

namespace Ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contrasena = 0;

            while (contrasena != 1111)
            {
                Console.Write("Introduce la contraseña: ");
                contrasena = Convert.ToInt32(Console.ReadLine());

                if (contrasena != 1111)
                    Console.WriteLine("Contraseña incorrecta");
            }

            Console.WriteLine("Contraseña correcta.");
        }
    }
}
