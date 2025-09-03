/*
Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), recuperación (50–69) o reprobó (<50) 
con switch.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una calificacion");
        int calificacion = int.Parse(Console.ReadLine());

        switch (calificacion)
        {
            case int calificacion when (calificacion >= 70):
                Console.WriteLine("Aprobado");
                break;
            case int calificacion when (calificacion >= 50):
                Console.WriteLine("Recuperación");
                break;
            default:
                Console.WriteLine("Reprobado");
                break;
        }
    }
}
