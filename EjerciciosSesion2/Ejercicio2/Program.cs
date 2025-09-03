// Pedir un número entre 1 y 7 y mostrar el día de la semana con switch.

using System;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido. Por favor ingrese un número entre 1 y 7.");
                break;
        }
    }
}
