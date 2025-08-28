/* Desarrolle un programa que calcule la distancia total recorrida en kilómetros por un ciclista 
en el malecón de San Juan del Sur, utilizando como entradas la velocidad promedio 
en kilómetros por hora y el tiempo recorrido, ambos proporcionados por el usuario.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la velocidad promedio en km/h: ");
        double velocidad = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo recorrido en horas: ");
        double tiempo = Convert.ToDouble(Console.ReadLine());

        double distancia = velocidad * tiempo;

        Console.WriteLine($"La distancia total recorrida es: {distancia} km");
    }
}