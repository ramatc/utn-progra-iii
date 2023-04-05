using System;

namespace Triangulos
{
    class Program
    {
        static void Main()
        {
            float ladoA, ladoB, ladoC;

            Console.Write("Ingresé el lado A del triangulo: ");
            while (!float.TryParse(Console.ReadLine(), out ladoA) || ladoA < 0)
            {
                Console.Write("Ingresé una longitud valida: ");
            }

            Console.Write("Ingresé el lado B del triangulo: ");
            while (!float.TryParse(Console.ReadLine(), out ladoB) || ladoB < 0)
            {
                Console.Write("Ingresé una longitud valida: ");
            }

            Console.Write("Ingresé el jlado C del triangulo: ");
            while (!float.TryParse(Console.ReadLine(), out ladoC) || ladoC < 0)
            {
                Console.Write("Ingresé una longitud valida: ");
            }

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("El triángulo es equilátero");
            }
            else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}