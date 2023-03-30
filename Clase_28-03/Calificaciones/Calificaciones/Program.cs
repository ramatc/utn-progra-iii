using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Calificaciones
    {
        static void Main()
        {
            ushort calif;
            int calificaciones = 0;
            int count = 0;

            do
            {
                Console.WriteLine("Ingresé una calificación");
                calif = ushort.Parse(s: Console.ReadLine());
                calificaciones = calificaciones + calif;
                count++;
            } while (calif > 0 && calif <= 10);

            if (count > 1) count = count - 1;

            Console.WriteLine("El promedio de calificaciones es: " + (calificaciones / (float)(count)).ToString());
            Console.ReadLine();
        }
    }
}
