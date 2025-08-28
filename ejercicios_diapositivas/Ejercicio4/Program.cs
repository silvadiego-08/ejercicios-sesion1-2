/* Desarrolle un programa que calcule el volumen total en metros cúbicos de agua recolectada en un 
tanque en una finca de Masaya, utilizando como entradas la longitud, el ancho y la altura del tanque, 
todos proporcionados por el usuario.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la longitud del tanque en metros: ");
        double longitud = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el ancho del tanque en metros: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del tanque en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volumen = longitud * ancho * altura;

        Console.WriteLine($"El volumen total de agua recolectada es: {volumen} m³");
    }
}