using System;

namespace ejercicio_3_2_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 20; x++)
            {
                Console.WriteLine("{0}² - 1 = {1}", x, Math.Pow(x, 2) - 1);
            }
        }
    }
}
