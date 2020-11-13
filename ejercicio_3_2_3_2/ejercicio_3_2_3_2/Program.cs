using System;

namespace ejercicio_3_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros;
            double kilometros;
            double millas;
            double horas;
            double minutos;
            double segundos;
            double tiempo;

            Console.Write("Escribe una distancia en metros: ");
            metros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el tiempo necesario para recorrerla.");
            Console.Write("Horas: ");
            horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Minutos: ");
            minutos = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundos: ");
            segundos = Convert.ToDouble(Console.ReadLine());

            tiempo = (horas * 3600) + (minutos * 60) + segundos; // El tiempo total en segundos.
            kilometros = metros / 1000;
            millas = metros / 1609;

            Console.WriteLine("{0} metros en {1} segundos = {2} m/s", metros, tiempo, metros / tiempo);

            tiempo /= 3600; // Pasamos el tiempo a horas.

            Console.WriteLine("{0} kilómetros en {1} horas = {2} Km/h", kilometros, tiempo, kilometros / tiempo);
            Console.WriteLine("{0} millas en/ {1} horas = {2} mi/h", millas, tiempo, millas / tiempo);
        }
    }
}
