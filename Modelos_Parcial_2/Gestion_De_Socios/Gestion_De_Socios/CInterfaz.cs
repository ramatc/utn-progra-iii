namespace Gestion_De_Socios
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string DarOpcion()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*        Sistema de Gestión de Socios         *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[1] Registrar un equipo.");
            Console.WriteLine("\n[2] Registar un jugador.");
            Console.WriteLine("\n[3] Registrar un entrenador.");
            Console.WriteLine("\n[4] Listar todos los equipos.");
            Console.WriteLine("\n[5] Listar jugadores de un equipo.");
            Console.WriteLine("\n[6] Remover un socio.");
            Console.WriteLine("\n[7] Listar todos los socios.");
            Console.WriteLine("\n[S] Salir de la aplicación.");
            Console.WriteLine("\n**********************************************");
            return CInterfaz.PedirDato("opción elegida");
        }
        public static string PedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.
        }
        public static void MostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}