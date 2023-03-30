// Un club deportivo clasifica a sus socios en diferentes categorias:

// Infantil: Hasta los 12 años inclusive
// Juvenil: Mayores a 12 hasta los 18 años inclusive
// Adulto: Mayores a 18 hasta los 60 años inclusive
// Veterano: Mayores a 60 inclusive

// Se solicita un programa que solicite una cantidad desconocida de socios, pidiendo
// numero de asociado (entero sin signo, uint), edad y nombre completo.
// Finalizando el proceso de ingreso con numero de asociado == 0 (no solicitar edad ni nombre)

// El programa debera informar:  
// Cantidad de socios por categoria
// Numero de asociado, nombre y edad del socio mas viejo (si hay mas de uno, el de menor numero de socio)
// NO USAR VECTORES

namespace Categorias
{
    class Socios
    {
        static void Main()
        {
            uint id_socio, max_id = 0;
            ushort edad, max_edad = 0;
            string nombre, max_nombre = "";
            ushort cant_infantiles = 0, cant_juveniles = 0, cant_adultos = 0, cant_veteranos = 0;

            Console.Write("Ingrese número de asociado (0 para terminar): ");
            while (uint.TryParse(Console.ReadLine(), out id_socio) != true)
            {
                Console.Write("Ingresé un número de socio valido: ");
            }

            while (id_socio != 0)
            {
                Console.Write("Ingresé la edad del asociado: ");
                edad = ushort.Parse(Console.ReadLine());

                Console.Write("Ingresé el nombre del asociado: ");
                nombre = Console.ReadLine();

                if (edad > 0 && edad <= 12)
                {
                    cant_infantiles++;
                }
                else if (edad > 12 && edad <= 18)
                {
                    cant_juveniles++;
                }
                else if (edad > 18 && edad <= 60)
                {
                    cant_adultos++;
                }
                else
                {
                    cant_veteranos++;
                }

                if (edad > max_edad || (max_edad == edad && id_socio < max_id))
                {
                    max_edad = edad;
                    max_id = id_socio;
                    max_nombre = nombre;
                }

                Console.Write("\nIngrese número de asociado (0 para terminar): ");
                id_socio = uint.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nCantidad de socios por categoría:");
            Console.WriteLine($"Infantiles: {cant_infantiles}, Juveniles: {cant_juveniles}, Adultos {cant_adultos}, Veteranos {cant_veteranos}");
            Console.WriteLine($"\nSocio más viejo: {max_id} - {max_nombre} - {max_edad} años");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}