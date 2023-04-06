namespace Triangulos
{
    class Program
    {
        static void Main()
        {
            float ladoA, ladoB, ladoC, perimetro, mayorPerimetro = 0, ladoMayorA = 0, ladoMayorB = 0, ladoMayorC = 0;
            ushort triangulosIngresados = 0, triangulosEquilateros = 0, triangulosIsosceles = 0, triangulosEscalenos = 0;
            bool esTriangulo = true;

            do
            {
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

                Console.Write("Ingresé el lado C del triangulo: ");
                while (!float.TryParse(Console.ReadLine(), out ladoC) || ladoC < 0)
                {
                    Console.Write("Ingresé una longitud valida: ");
                }

                if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
                {
                    triangulosIngresados++;

                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("El triángulo es equilátero\n");
                        triangulosEquilateros++;
                    }
                    else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
                    {
                        Console.WriteLine("El triángulo es escaleno\n");
                        triangulosEscalenos++;
                    }
                    else
                    {
                        Console.WriteLine("El triángulo es isósceles\n");
                        triangulosIsosceles++;
                    }

                    perimetro = ladoA + ladoB + ladoC;

                    if (perimetro > mayorPerimetro)
                    {
                        mayorPerimetro = perimetro;
                        ladoMayorA = ladoA;
                        ladoMayorB = ladoB;
                        ladoMayorC = ladoC;
                    }
                }
                else
                {
                    Console.WriteLine("Los valores ingresados no constituyen un triángulo.");
                    esTriangulo = false;
                }
            } while (esTriangulo);

            if (triangulosIngresados > 0)
            {
                Console.WriteLine($"\nTotal de triángulos válidos ingresados: {triangulosIngresados}");
                Console.WriteLine($"Cantidad de triángulos equiláteros: {triangulosEquilateros} - Porcentaje: {triangulosEquilateros * 100 / triangulosIngresados}%");
                Console.WriteLine($"Cantidad de triángulos isósceles: {triangulosIsosceles} - Porcentaje: {triangulosIsosceles * 100 / triangulosIngresados}%");
                Console.WriteLine($"Cantidad de triángulos escalenos: {triangulosEscalenos} - Porcentaje: {triangulosEscalenos * 100 / triangulosIngresados}%");

                Console.WriteLine($"\nMayor perímetro: {mayorPerimetro} ({ladoMayorA}-{ladoMayorB}-{ladoMayorC})");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron triángulos válidos.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}