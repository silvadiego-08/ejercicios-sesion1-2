// See https://aka.ms/new-console-template for more information
/*Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular en una finca nicaraguense, donde el usuario
ingresa la longitud y el ancho en varas (1 manzana = 1,428.8 varas2), utilizando una cantidad
fija de 5 varas de ancho y la longitud como entrada.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double longitud, areaManzanas;
        const double ancho = 5;
        const double varasPorManzana = 1428.8;

        Console.WriteLine("Ingrese la longitud del terreno en varas:");
        longitud = Convert.ToDouble(Console.ReadLine());

        // Calcular el área en varas cuadradas
        double areaVaras = longitud * ancho;

        // Convertir el área a manzanas
        areaManzanas = areaVaras / varasPorManzana;

        Console.WriteLine($"El área total del terreno es: {areaManzanas} manzanas");
    }
}

