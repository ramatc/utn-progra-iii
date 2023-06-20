using System;

namespace Lista_de_Apellidos
{
    class CEjecutora
    {
        static void Main()
        {
            const ushort maxApel= 10;
            string auxApel;
            ushort contApel = 0;
            string[] listado;
            listado = new string[maxApel];
            Console.Write("Ingrese el Apellido - Salir para Finalizar: ");
            auxApel = Console.ReadLine();
            while((auxApel.ToUpper()!="SALIR")&&(contApel<maxApel))
            {
                listado[contApel] = auxApel;
                contApel++;
                Console.Write("Ingrese el Apellido - Salir para Finalizar: ");
                auxApel = Console.ReadLine();
            }
            Console.WriteLine("=>Apellidos en Orden de Ingreso");
            for (ushort cont=0; cont<contApel;cont++)
            {
                Console.WriteLine(" ->" + listado[cont]);
            }
            Console.WriteLine("=>Apellidos en Orden Alfabético");
            Array.Sort(listado, 0, contApel);
            for (ushort cont = 0; cont < contApel; cont++)
            {
                Console.WriteLine(" ->" + listado[cont]);
            }
            Console.WriteLine("Para finalizar pulse <ENTER>");
            Console.ReadLine();
        }
    }
}
