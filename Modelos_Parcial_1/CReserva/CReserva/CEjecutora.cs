using System;

namespace Sala_De_Ensayo
{
    public class CEjecutora
    {
        public static void Main()
        {
            float total = 0;
            ulong num_reserva;
            string inicio, banda;
            ushort duracion_reserva;
            CReserva res1, maymon = new CReserva("", 0, "");

            Console.WriteLine("Ingrese el costo por hora de la reserva: ");
            CReserva.Cost = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el descuento: ");
            CReserva.Desc = (float.Parse(Console.ReadLine()));

            Console.Write("\nIngrese número de reserva (0 para terminar): ");
            while (ulong.TryParse(Console.ReadLine(), out num_reserva) != true)
            {
                Console.Write("Ingresé un número de reserva valido: ");
            }
            if (num_reserva == 0)
            {
                Console.WriteLine("No se ingresaron reservas validas");
            }
            else
            {
                while (num_reserva != 0)
                {
                    Console.Write("Ingresé el inicio de la reserva: ");
                    inicio = Console.ReadLine();

                    Console.Write("Ingresé la duración de la reserva: ");
                    duracion_reserva = ushort.Parse(Console.ReadLine());

                    Console.Write("Ingresé el nombre de la banda: ");
                    banda = Console.ReadLine();

                    res1 = new CReserva(inicio, duracion_reserva, banda);
                    res1.Numres = (num_reserva);

                    Console.WriteLine("Costo: " + res1.DarMontoTotal() + "$");
                    total += res1.DarMontoTotal(450);

                    if (CReserva.MayorMonto(res1, maymon) == res1) maymon = res1;

                    Console.Write("\nIngrese número de reserva (0 para terminar): ");
                    num_reserva = ulong.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n\n" + maymon.DarDatos() + "\n\nEl total recaudado es de " + total + " Dolares ( a 450 pesos) o " + total * 450 + " pesos\n\n");
            }
        }
    }
}