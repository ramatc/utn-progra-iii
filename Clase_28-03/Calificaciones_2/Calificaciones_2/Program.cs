//Archivo Calificaciones_2.cs
using System;

namespace Promedio
{
    class Calificaciones_2
    {
        public static void Main()
        {
            ushort calif;
            ushort acum = 0;
            ushort count = 0;
            float promedio;
            ushort cocienteEnt;

            Console.Write("Ingrese calificación [1-10] o 0 para finalizar: ");
            while (ushort.TryParse(Console.ReadLine(), out calif) != true || calif > 10)
            {
                Console.WriteLine("Ingreso erróneo");
                Console.Write("Ingrese calificación [1-10] o 0 para finalizar: ");
            }

            while (calif != 0)
            {
                acum += calif;
                count++;
                Console.Write("Ingrese calificación [1-10] o 0 para finalizar: ");
                while (ushort.TryParse(Console.ReadLine(), out calif) != true || calif > 10)
                {
                    Console.WriteLine("Ingreso erróneo");
                    Console.Write("Ingrese calificación [1-10] o 0 para finalizar: ");
                }
            }

            if (count == 0) Console.Write("No se ingresaron calificaciones - El promedio es: 0");
            else
            {
                promedio = ((float)acum) / count;
                cocienteEnt = (ushort)(acum / count);
                if ((promedio - cocienteEnt) >= 0.5F) cocienteEnt++;
                Console.Write("Promedio Real: {0} - Entero {1}", promedio, cocienteEnt);
            }

            Console.Write("\nPulse <Enter>");
            _ = Console.ReadLine();
        }
    }
}