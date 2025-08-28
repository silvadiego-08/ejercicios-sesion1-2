// See https://aka.ms/new-console-template for more information
/* Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada, 
donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, 
asumiendo una distancia fija de 40 kilómetros.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la velocidad promedio en km/h: ");
        double velocidad = Convert.ToDouble(Console.ReadLine());

        double distancia = 40; // distancia fija en kilómetros
        double tiempo = distancia / velocidad; // tiempo en horas

        Console.WriteLine($"El tiempo total del viaje es: {tiempo} horas");
    }
}
