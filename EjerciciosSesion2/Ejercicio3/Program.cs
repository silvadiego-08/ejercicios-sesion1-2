/* Evaluar la calificación de un estudiante y mostrar si aprobó 
(≥70), recuperación (50–69) o reprobó (<50) con if.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una calificacion");
        int calificacion = int.Parse(Console.ReadLine());

        if (calificacion >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else if (calificacion >= 50)
        {
            Console.WriteLine("Recuperación");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}