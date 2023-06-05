using System;
namespace Facultad
{
    public class CEJecutora
    {
        public static void Main(string[] args)
        {
            CAlumno auxAl;
            CAlumno[] vecAl;
            vecAl = new CAlumno[8];
            auxAl = new CAlumno(10731UL, "Pérez", "Rocio", 0);
            vecAl[0] = auxAl;
            vecAl[2] = new CAlumno(10755UL, "Ruiz", "Pablo", 0);
            vecAl[3] = new CAlumno();
            vecAl[3].SetLegajo(10722UL);
            CAlumno alumno3 = (CAlumno)vecAl.GetValue(3);
            alumno3.SetBeca(50.0f);
            vecAl[1] = vecAl[3];

            for(int cont = 0; cont < vecAl.GetLength(0); cont++)
            {
                if (vecAl[cont] != null)
                {
                    Console.WriteLine("N{0}: {1}", cont, vecAl[cont].DarDatos());
                }
            }

            Console.WriteLine();
            foreach (CAlumno aux in vecAl)
            {
                Console.WriteLine("{0}", aux.DarDatos());
            }
        }
    }
}