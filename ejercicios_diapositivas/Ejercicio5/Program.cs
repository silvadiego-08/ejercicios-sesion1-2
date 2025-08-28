/* Desarrolle un programa que calcule la cantidad total de baldes de leche producida
en un día en una lechería de Estelí, utilizando como entradas el volumen promedio por vaca en litros y el número total 
de vacas ordeñadas, ambos proporcionados por el usuario (1 balde = 20 litros).

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el volumen promedio por vaca en litros: ");
        double volumenPorVaca = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número total de vacas ordeñadas: ");
        int numeroDeVacas = Convert.ToInt32(Console.ReadLine());

        double totalLitros = volumenPorVaca * numeroDeVacas;
        double totalBaldes = totalLitros / 20;

        Console.WriteLine($"La cantidad total de baldes de leche producida es: {totalBaldes} baldes");
    }
}