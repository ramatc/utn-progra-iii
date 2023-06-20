using System;
using System.Collections.Generic;
namespace Lista_de_Apellidos
{
    class CEjecutora
    {
        static void Main()
        {
            string auxApel;
            List<string> listado;
            listado = new List<string>();
            Console.Write("Ingrese el Apellido - Salir para Finalizar: ");
            auxApel = Console.ReadLine();
            while((auxApel.ToUpper()!="SALIR"))
            {
                listado.Add(auxApel);
                Console.Write("Ingrese el Apellido - Salir para Finalizar: ");
                auxApel = Console.ReadLine();
            }
            Console.WriteLine("=>Apellidos en Orden de Ingreso");
            foreach(string aux in listado)
            {
                Console.WriteLine(" ->" + aux);
            }
            Console.WriteLine("=>Apellidos en Orden Alfabético");
            listado.Sort();
            for (ushort cont = 0; cont < listado.Count; cont++)
            {
                Console.WriteLine(" ->" + listado[cont]);
            }
            Console.WriteLine("Para finalizar pulse <ENTER>");
            Console.ReadLine();
        }
    }
}
