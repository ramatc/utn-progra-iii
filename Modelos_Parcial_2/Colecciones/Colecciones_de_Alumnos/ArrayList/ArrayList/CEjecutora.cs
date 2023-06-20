using System.Collections;
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
            ArrayList vec = new ArrayList(maxAlumnos);

            Console.Write("Ingrese el valor de la cuota: $");
            CAlumno.setCUOTA(Convert.ToSingle(Console.ReadLine()));

            Console.Write("\nIngrese el legajo del alumno ('0' para finalizar): ");
            leg = Convert.ToUInt64(Console.ReadLine());

            while (leg != 0 && contAlumnos < maxAlumnos)
            {
                CAlumno auxAl = new CAlumno();
                vec.Add(auxAl);

                auxAl.setLegajo(leg);

                Console.Write("Ingrese el apellido del alumno: ");
                auxAl.setApellidos(Console.ReadLine());

                Console.Write("Ingrese el nombre del alumno: ");
                auxAl.setNombres(Console.ReadLine());

                Console.Write("Ingrese la beca: ");
                auxAl.setBeca(Convert.ToSingle(Console.ReadLine()));

                contAlumnos++;
                Console.Clear();
                Console.Write("Ingrese el legajo del alumno ('0' para finalizar): ");
                leg = Convert.ToUInt64(Console.ReadLine());
            }

            Console.WriteLine("=>Alumnos en orden de ingreso:");
            foreach(CAlumno auxAl in vec){
                Console.WriteLine(" ->" + auxAl.darDatos());
            }

            for (int contA = 0; contA < vec.Count - 1; contA++)
                for (int contB = contA + 1; contB < vec.Count; contB++)
                {
                    if (((CAlumno)vec[contA]).getLegajo() > ((CAlumno)vec[contB]).getLegajo())
                    {
                        //Swap
                        object auxAlumno = vec[contA];
                        vec[contA] = vec[contB];
                        vec[contB] = auxAlumno;
                    }
                }

            Console.WriteLine("=>Alumnos en orden de menor a mayor número de legajo:");
            foreach (CAlumno auxAl in vec){
                Console.WriteLine(" ->" + auxAl.darDatos());
            }

            Console.WriteLine("Para finalizar pulse <ENTER>");
            Console.ReadLine();
        }
    }
}