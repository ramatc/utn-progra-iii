using System;

namespace Clase4_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort corto;
            float flotante;
            char caracter, caracterInvertido;
            string cadena, invertida = "";
            bool booleano;

            Console.Write("Ingrese un valor numerico corto: ");
            corto = ushort.Parse(Console.ReadLine());

            Console.Write("Ingrese un flotante: ");
            flotante = float.Parse(Console.ReadLine());

            Console.Write("Ingrese un caracter: ");
            caracter = char.Parse(Console.ReadLine());

            Console.Write("Ingrese una cadena de caracteres: ");
            cadena = Console.ReadLine();

            Console.Write("Ingrese un valor booleano: ");
            booleano = bool.Parse(Console.ReadLine());

            if (char.IsLower(caracter)) caracterInvertido = Char.ToUpper(caracter);
            else caracterInvertido = Char.ToLower(caracter);

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                invertida += cadena[i];
            }

            Console.WriteLine($"1) {corto + 1}");
            Console.WriteLine($"2) {corto + flotante}");
            Console.WriteLine($"3) {(char)(caracter + 1)}");
            Console.WriteLine($"4) {(caracterInvertido)}");
            Console.WriteLine($"5) {invertida}");
            Console.WriteLine($"6) {!booleano}");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}