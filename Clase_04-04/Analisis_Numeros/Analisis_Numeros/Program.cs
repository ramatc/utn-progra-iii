namespace Analisis_Numeros
{
    class Program
    {
        static void Main()
        {
            ulong num1, num2, mayor, menor, mcd = 1;
            bool esPrimo = true;

            Console.Write("Ingresé el primer entero largo: ");
            while (!ulong.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingresé un entero valido: ");
            }

            Console.Write("Ingresé el segundo entero largo: ");
            while (!ulong.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingresé un entero valido: ");
            }

            if (num1 > num2)
            {
                Console.WriteLine($"\na) El mayor es {num1} y el menor es {num2}");
                mayor = num1;
                menor = num2;
            }
            else
            {
                Console.WriteLine($"\na) El mayor es {num2} y el menor es {num1}");
                mayor = num2;
                menor = num1;
            }

            Console.WriteLine($"\nb) Números primos comprendidos entre {menor} y {mayor}: ");
            for (ulong i = menor; i <= mayor; i++)
            {
                esPrimo = true;
                for (ulong j = 2; j < i && esPrimo; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo && i > 1) { Console.WriteLine(i); }
            }

            if (mayor % menor == 0) Console.WriteLine($"c) {mayor} es múltiplo de {menor}");
            else Console.WriteLine($"\nc) Los números ingresados no son múltiplos entre sí.");

            for (ulong i = 1; i <= mayor; i++)
            {
                if (mayor % i == 0)
                {
                    for (ulong j = 1; j <= menor; j++)
                    {
                        if (menor % j == 0 && i == j)
                        {
                            mcd = i;
                        }
                    }
                }
            }
            Console.WriteLine($"\nd) El divisor común mayor de {menor} y {mayor}: {mcd}");

            Console.WriteLine($"\ne) El múltiplo común menor de {menor} y {mayor}: {(mayor * menor) / mcd}");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}