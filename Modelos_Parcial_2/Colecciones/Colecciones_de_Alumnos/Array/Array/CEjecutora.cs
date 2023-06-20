using System;
using Alumnos;
namespace Lista_de_Alumnos
{
    class CEjecutora
    {
        static void Main()
        {
            const ushort maxAlumnos = 10;
            ushort contAlumnos = 0;
            ulong leg;
            CAlumno[] vec = new CAlumno[maxAlumnos];

            Console.Write("Ingrese el valor de la cuota: $");
            CAlumno.setCUOTA(Convert.ToSingle(Console.ReadLine()));

            Console.Write("\nIngrese el legajo del alumno ('0' para finalizar): ");
            leg = Convert.ToUInt64(Console.ReadLine());

            while(leg != 0 && contAlumnos < maxAlumnos)
            {
                vec[contAlumnos] = new CAlumno();

                vec[contAlumnos].setLegajo(leg);

                Console.Write("Ingrese el apellido del alumno: ");
                vec[contAlumnos].setApellidos(Console.ReadLine());

                Console.Write("Ingrese el nombre del alumno: ");
                vec[contAlumnos].setNombres(Console.ReadLine());

                Console.Write("Ingrese la beca: ");
                vec[contAlumnos].setBeca(Convert.ToSingle(Console.ReadLine()));

                contAlumnos++;
                Console.Clear();
                Console.Write("Ingrese el legajo del alumno ('0' para finalizar): ");
                leg = Convert.ToUInt64(Console.ReadLine());
            }

            Console.WriteLine("=>Alumnos en orden de ingreso:");
            for(int i = 0; i < contAlumnos; i++)
            {
                Console.WriteLine(vec[i].darDatos());
            }

            for (int contA = 0; contA < contAlumnos - 1; contA++)
                for (int contB = contA + 1; contB < contAlumnos; contB++)
                {
                    if (vec[contA].getLegajo() > vec[contB].getLegajo())
                    {
                        //Swap
                        CAlumno auxAlumno = vec[contA];
                        vec[contA] = vec[contB];
                        vec[contB] = auxAlumno;
                    }
                }

            Console.WriteLine("=>Alumnos en orden de menor a mayor número de legajo:");
            for (ushort cont = 0; cont < contAlumnos; cont++)
            {
                Console.WriteLine(" ->" + vec[cont].darDatos());
            }

            Console.WriteLine("Para finalizar pulse <ENTER>");
            Console.ReadLine();
        }
    }
}
