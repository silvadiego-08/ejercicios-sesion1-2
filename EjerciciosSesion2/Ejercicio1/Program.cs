// Determinar si un número ingresado es positivo, negativo o cero usando if.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}
